//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Inventories = new HashSet<Inventory>();
        }
    
        public System.Guid Guid { get; set; }
        public string Gtin { get; set; }
        public string NewSku { get; set; }
        public string UsedSku { get; set; }
        public string GameCompanyPartNumber { get; set; }
        public System.Guid GameGuid { get; set; }
        public int PublisherId { get; set; }
        public int DeveloperId { get; set; }
        public string PlatformCode { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public decimal Msrp { get; set; }
        public decimal NewStorePrice { get; set; }
        public decimal NewWebPrice { get; set; }
        public Nullable<bool> AcceptUsed { get; set; }
        public Nullable<decimal> UsedCustomerCredit { get; set; }
        public Nullable<decimal> UsedStorePrice { get; set; }
        public Nullable<decimal> UsedWebPrice { get; set; }
        public string UserName { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual GameCompany GameCompany { get; set; }
        public virtual GameCompany GameCompany1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual Platform Platform { get; set; }
    }
}
