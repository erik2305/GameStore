using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public static class MetaGameStatu
    {
        [Required]
        [DisplayName("Availability")]
        public static string Code { get; set; }
        [DisplayName("Availability")]
        public static string EnglishCategory { get; set; }
        [DisplayName("Availability")]
        public static string FrenchCategory { get; set; }
    }
}