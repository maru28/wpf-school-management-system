//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeeAssociationTable
    {
        public int AssociationID { get; set; }
        public int FeeID { get; set; }
        public int AdmissionNumber { get; set; }
        public int FeeAmount { get; set; }
        public string FeeMonth { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<int> Fine { get; set; }
        public System.DateTime AppliedOn { get; set; }
        public string Status { get; set; }
    
        public virtual FeeTable FeeTable { get; set; }
        public virtual StudentTable StudentTable { get; set; }
    }
}