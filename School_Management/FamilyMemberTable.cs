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
    
    public partial class FamilyMemberTable
    {
        public int Count { get; set; }
        public int FamilyId { get; set; }
        public int AdmissionNumber { get; set; }
        public System.DateTime AddedOn { get; set; }
    
        public virtual FamilyTable FamilyTable { get; set; }
        public virtual StudentTable StudentTable { get; set; }
    }
}
