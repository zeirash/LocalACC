//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmallProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTransaction()
        {
            this.tblDetails = new HashSet<tblDetail>();
        }
    
        public int TransactionId { get; set; }
        public int ShopId { get; set; }
        public string NotaNumber { get; set; }
        public Nullable<double> Discount { get; set; }
        public System.DateTime Date { get; set; }
        public string Information { get; set; }
        public string Status { get; set; }
        public Nullable<int> TotalHarga { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDetail> tblDetails { get; set; }
        public virtual tblShop tblShop { get; set; }
    }
}