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
    
    public partial class EarnedBadge
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> AwardPayoutThreshold { get; set; }
        public string ADName { get; set; }
        public int BadgeId { get; set; }
        public string BadgeName { get; set; }
        public string BadgeTagLine { get; set; }
        public string BadgeDescription { get; set; }
        public int BadgeTypeId { get; set; }
        public string BadgePath { get; set; }
        public System.DateTime BadgeCreated { get; set; }
        public Nullable<System.DateTime> BadgeEffectiveStart { get; set; }
        public Nullable<System.DateTime> BadgeEffectiveEnd { get; set; }
        public int BadgePriority { get; set; }
        public bool MultipleAwardPossible { get; set; }
        public bool DisplayOnce { get; set; }
        public bool ManagementApprovalRequired { get; set; }
        public int ActivityPointsAmount { get; set; }
        public int BadgeAwardValueAmount { get; set; }
        public Nullable<int> BadgeApprovedById { get; set; }
        public Nullable<System.DateTime> BadgeApprovedDate { get; set; }
        public string BadgeTypeName { get; set; }
        public bool PayrollEligible { get; set; }
        public System.DateTime AwardDate { get; set; }
        public int AwardAmount { get; set; }
        public bool PaidOut { get; set; }
        public int BadgeAwardId { get; set; }
    }
}
