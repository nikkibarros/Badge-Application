//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magenic.BadgeApplication.DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public Activity()
        {
            this.BadgeActivities = new HashSet<BadgeActivity>();
            this.ActivitySubmissions = new HashSet<ActivitySubmission>();
        }
    
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDescription { get; set; }
        public bool RequiresApproval { get; set; }
        public int CreateEmployeeId { get; set; }
        public int EntryTypeId { get; set; }
    
        public virtual ICollection<BadgeActivity> BadgeActivities { get; set; }
        public virtual ICollection<ActivitySubmission> ActivitySubmissions { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ActivityEntryType ActivityEntryType { get; set; }
    }
}
