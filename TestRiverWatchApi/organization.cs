//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestRiverWatchApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class organization
    {
        public int ID { get; set; }
        public Nullable<int> KitNumber { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationType { get; set; }
        public string Email { get; set; }
        public string MailingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string YearStarted { get; set; }
        public string WaterShed { get; set; }
        public string WaterShedGathering { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string UserCreated { get; set; }
        public Nullable<System.DateTime> DateLastModified { get; set; }
        public string UserLastModified { get; set; }
        public Nullable<bool> Valid { get; set; }
    }
}