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
    
    public partial class DiscountTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiscountTable()
        {
            this.StudentDiscountTables = new HashSet<StudentDiscountTable>();
        }
    
        public int DiscountID { get; set; }
        public string DiscountTitle { get; set; }
        public int DiscountAmount { get; set; }
        public Nullable<int> DiscountByPercentage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentDiscountTable> StudentDiscountTables { get; set; }
    }
}
