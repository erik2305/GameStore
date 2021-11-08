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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Person
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ProvinceCode { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public string LandLine { get; set; }
        public string Extension { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        [Required(ErrorMessage = "Input Email", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="Input User name", AllowEmptyStrings = false)]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Input Password", AllowEmptyStrings = false)]
        [StringLength(30, MinimumLength = 8, ErrorMessage ="Password must be at least 8 characters long")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Passwords doesn't match")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string LoginErrorMessage { get; set; }

        public virtual Country Country { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Province Province { get; set; }
    }
}
