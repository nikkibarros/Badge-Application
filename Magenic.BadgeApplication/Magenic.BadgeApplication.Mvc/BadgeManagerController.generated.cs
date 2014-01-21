// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4Mvc;
namespace Magenic.BadgeApplication.Controllers
{
    public partial class BadgeManagerController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BadgeManagerController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected BadgeManagerController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> AddBadgePost()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddBadgePost);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditBadge()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditBadge);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditBadgePost()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditBadgePost);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ApproveActivity()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApproveActivity);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RejectActivity()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RejectActivity);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BadgeManagerController Actions { get { return Mvc.BadgeManager; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "BadgeManager";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "BadgeManager";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string AddBadge = "AddBadge";
            public readonly string AddBadgePost = "AddBadgePost";
            public readonly string EditBadge = "EditBadge";
            public readonly string EditBadgePost = "EditBadgePost";
            public readonly string ApproveCommunityBadges = "ApproveCommunityBadges";
            public readonly string PointsReport = "PointsReport";
            public readonly string ApproveActivities = "ApproveActivities";
            public readonly string ApproveActivity = "ApproveActivity";
            public readonly string RejectActivity = "RejectActivity";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string AddBadge = "AddBadge";
            public const string AddBadgePost = "AddBadgePost";
            public const string EditBadge = "EditBadge";
            public const string EditBadgePost = "EditBadgePost";
            public const string ApproveCommunityBadges = "ApproveCommunityBadges";
            public const string PointsReport = "PointsReport";
            public const string ApproveActivities = "ApproveActivities";
            public const string ApproveActivity = "ApproveActivity";
            public const string RejectActivity = "RejectActivity";
        }


        static readonly ActionParamsClass_AddBadgePost s_params_AddBadgePost = new ActionParamsClass_AddBadgePost();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddBadgePost AddBadgePostParams { get { return s_params_AddBadgePost; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddBadgePost
        {
            public readonly string badgeImage = "badgeImage";
        }
        static readonly ActionParamsClass_EditBadge s_params_EditBadge = new ActionParamsClass_EditBadge();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditBadge EditBadgeParams { get { return s_params_EditBadge; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditBadge
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_EditBadgePost s_params_EditBadgePost = new ActionParamsClass_EditBadgePost();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditBadgePost EditBadgePostParams { get { return s_params_EditBadgePost; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditBadgePost
        {
            public readonly string id = "id";
            public readonly string badgeImage = "badgeImage";
        }
        static readonly ActionParamsClass_ApproveActivity s_params_ApproveActivity = new ActionParamsClass_ApproveActivity();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ApproveActivity ApproveActivityParams { get { return s_params_ApproveActivity; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ApproveActivity
        {
            public readonly string approveActivityItem = "approveActivityItem";
        }
        static readonly ActionParamsClass_RejectActivity s_params_RejectActivity = new ActionParamsClass_RejectActivity();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RejectActivity RejectActivityParams { get { return s_params_RejectActivity; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RejectActivity
        {
            public readonly string approveActivityItem = "approveActivityItem";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _ActivitiesForApproval = "_ActivitiesForApproval";
                public readonly string _AdminBadgeList = "_AdminBadgeList";
                public readonly string AddBadge = "AddBadge";
                public readonly string ApproveActivities = "ApproveActivities";
                public readonly string ApproveCommunityBadges = "ApproveCommunityBadges";
                public readonly string EditBadge = "EditBadge";
                public readonly string Index = "Index";
                public readonly string PointsReport = "PointsReport";
            }
            public readonly string _ActivitiesForApproval = "~/Views/BadgeManager/_ActivitiesForApproval.cshtml";
            public readonly string _AdminBadgeList = "~/Views/BadgeManager/_AdminBadgeList.cshtml";
            public readonly string AddBadge = "~/Views/BadgeManager/AddBadge.cshtml";
            public readonly string ApproveActivities = "~/Views/BadgeManager/ApproveActivities.cshtml";
            public readonly string ApproveCommunityBadges = "~/Views/BadgeManager/ApproveCommunityBadges.cshtml";
            public readonly string EditBadge = "~/Views/BadgeManager/EditBadge.cshtml";
            public readonly string Index = "~/Views/BadgeManager/Index.cshtml";
            public readonly string PointsReport = "~/Views/BadgeManager/PointsReport.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_BadgeManagerController : Magenic.BadgeApplication.Controllers.BadgeManagerController
    {
        public T4MVC_BadgeManagerController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void AddBadgeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> AddBadge()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddBadge);
            AddBadgeOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void AddBadgePostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Web.HttpPostedFileBase badgeImage);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> AddBadgePost(System.Web.HttpPostedFileBase badgeImage)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddBadgePost);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "badgeImage", badgeImage);
            AddBadgePostOverride(callInfo, badgeImage);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void EditBadgeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditBadge(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditBadge);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditBadgeOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void EditBadgePostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, System.Web.HttpPostedFileBase badgeImage);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditBadgePost(int id, System.Web.HttpPostedFileBase badgeImage)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditBadgePost);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "badgeImage", badgeImage);
            EditBadgePostOverride(callInfo, id, badgeImage);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ApproveCommunityBadgesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult ApproveCommunityBadges()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApproveCommunityBadges);
            ApproveCommunityBadgesOverride(callInfo);
            return callInfo;
        }

        partial void PointsReportOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult PointsReport()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PointsReport);
            PointsReportOverride(callInfo);
            return callInfo;
        }

        partial void ApproveActivitiesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ApproveActivities()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApproveActivities);
            ApproveActivitiesOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ApproveActivityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Magenic.BadgeApplication.BusinessLogic.Activity.ApproveActivityItem approveActivityItem);

        public override System.Web.Mvc.ActionResult ApproveActivity(Magenic.BadgeApplication.BusinessLogic.Activity.ApproveActivityItem approveActivityItem)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApproveActivity);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "approveActivityItem", approveActivityItem);
            ApproveActivityOverride(callInfo, approveActivityItem);
            return callInfo;
        }

        partial void RejectActivityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Magenic.BadgeApplication.BusinessLogic.Activity.ApproveActivityItem approveActivityItem);

        public override System.Web.Mvc.ActionResult RejectActivity(Magenic.BadgeApplication.BusinessLogic.Activity.ApproveActivityItem approveActivityItem)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RejectActivity);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "approveActivityItem", approveActivityItem);
            RejectActivityOverride(callInfo, approveActivityItem);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
