namespace GameStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public interface IPerson
    {
        int Id { get; set; }
        string Surname { get; set; }
        [DisplayName("First Name")]
        string GivenName { get; set; }
        string Street { get; set; } 
        string City { get; set; }
        string ProvinceCode { get; set; }
        string CountryCode { get; set; }
        string PostalCode { get; set; }
        string LandLine { get; set; }
        string Extension { get; set; }
        string Mobile { get; set; }
        string Fax { get; set; }
        [Required(ErrorMessage = "Input Email", AllowEmptyStrings = false)]
        string Email { get; set; }
        [Required(ErrorMessage = "Input User name", AllowEmptyStrings = false)]
        [DisplayName("User Name")]
        string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Input Password", AllowEmptyStrings = false)]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords doesn't match")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        string ConfirmPassword { get; set; }
        string LoginErrorMessage { get; set; }
    }
}