//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrder()
        {
            this.Warehouse_prod_salesOrd = new HashSet<Warehouse_prod_salesOrd>();
        }
    
        public int so_ID { get; set; }
        public Nullable<System.DateTime> ord_date { get; set; }
        public string Cst_name { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse_prod_salesOrd> Warehouse_prod_salesOrd { get; set; }
    }
}