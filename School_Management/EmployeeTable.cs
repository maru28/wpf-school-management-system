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
    
    public partial class EmployeeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeTable()
        {
            this.PaymentTables = new HashSet<PaymentTable>();
        }
    
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string FatherName { get; set; }
        public string Qualifications { get; set; }
        public string Adress { get; set; }
        public string PrimaryContact { get; set; }
        public string SecondaryContact { get; set; }
        public int Age { get; set; }
        public System.DateTime JoinedOn { get; set; }
        public string Subject { get; set; }
        public string Gender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentTable> PaymentTables { get; set; }
    }
}
