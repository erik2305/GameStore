using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public interface IGameStatu
    {
        [Required]
        [DisplayName("Availability")]
        string Code { get; set; }
        [DisplayName("Availability")]
        string EnglishCategory { get; set; }
        [DisplayName("Availability")]
        string FrenchCategory { get; set; }
    }
}