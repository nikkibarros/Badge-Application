﻿using System.Configuration;
using System.Linq;
using Autofac;
using Magenic.BadgeApplication.BusinessLogic.Framework;
using Magenic.BadgeApplication.Common;
using Magenic.BadgeApplication.Common.DTO;
using Magenic.BadgeApplication.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Magenic.BadgeApplication.Processor
{
    public class ADProcessor
    {
        public void Start()
        {
            while (true)
            {
                try
                {
                    var adDal = IoC.Container.Resolve<IAuthorizeLogOn>();
                    var dal = IoC.Container.Resolve<ICustomIdentityDAL>();

                    var employees = adDal.RetrieveActiveUsers().AsQueryable();

                    InsertEmployees(employees, adDal, dal);

                    MarkTermDateForMissingEmployees(adDal, dal);

                    SaveManagerInformation(employees, adDal, dal);

                    foreach (var employeeADName in employees)
                    {
                        dal.SetManagerPermission(employeeADName);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error<ADProcessor>(ex.Message, ex);
                }
                finally
                {
                    Thread.Sleep(SleepInterval);
                }
            }            
        }

        private void MarkTermDateForMissingEmployees(IAuthorizeLogOn adDal, ICustomIdentityDAL dal)
        {
            var userCollectionDal = IoC.Container.Resolve<IUserCollectionDAL>();
            var userCollection = userCollectionDal.GetActiveAdUsers();

            foreach (var userName in userCollection)
            {
                if (adDal.RetrieveUserInformation(userName) == null)
                {
                    dal.SetTerminationDate(userName, DateTime.UtcNow);
                }
            }
        }

        private int SleepInterval
        {
            get { return int.Parse(ConfigurationManager.AppSettings["SleepIntervalInMilliseconds"]); }
        }

        private static void SaveManagerInformation(IEnumerable<string> employees, IAuthorizeLogOn adDal, ICustomIdentityDAL dal)
        {
            foreach (var employeeADName in employees)
            {
                var employeeADInfo = adDal.RetrieveUserInformation(employeeADName);
                dal.SaveManagerInfo(employeeADInfo);
            }
        }

        private void InsertEmployees(IEnumerable<string> employees, IAuthorizeLogOn adDal, ICustomIdentityDAL dal)
        {
            foreach (var employeeADName in employees)
            {
                var result = Task.Run(() => dal.RetrieveIdentityAsync(employeeADName)).Result ??
                                InsertUserInfoFromAD(adDal, dal, employeeADName);
            }
        }

        private CustomIdentityDTO InsertUserInfoFromAD(IAuthorizeLogOn adDal, ICustomIdentityDAL dal, string userName)
        {
            var userADInfo = adDal.RetrieveUserInformation(userName);
            return dal.SaveIdentity(userADInfo);
        }
    }
}
