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
    
    public partial class SupplierContact
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string LandLine { get; set; }
        public string Extension { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }
    
        public virtual Supplier Supplier { get; set; }
    }
}
