//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OverseeingPerson
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public string Recommendations { get; set; }
        public string ActionNeeded { get; set; }
        public string ResponsibleOfficePerson { get; set; }
        public string ResourcesNeeded { get; set; }
        public string OverseeingPerson1 { get; set; }
        public Nullable<System.DateTime> TimeFrame { get; set; }
        public string Eveidences { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
