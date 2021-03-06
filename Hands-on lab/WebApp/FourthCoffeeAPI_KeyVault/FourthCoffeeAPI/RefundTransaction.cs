//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FourthCoffeeAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class RefundTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefundTransaction()
        {
            this.VoidTransactions = new HashSet<VoidTransaction>();
        }
    
        public System.Guid RefundTransactionId { get; set; }
        public Nullable<System.Guid> MasterTransactionId { get; set; }
        public Nullable<System.Guid> OrderTransactionId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual MasterTransaction MasterTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoidTransaction> VoidTransactions { get; set; }
    }
}
