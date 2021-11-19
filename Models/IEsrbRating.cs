using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public interface IEsrbRating
    {
        [Required]
        [DisplayName("ESRB")]
        string Code { get; set; }
        [DisplayName("ESRB")]
        string EnglishRating { get; set; }
        [DisplayName("ESRB")]
        string FrenchRating { get; set; }
    }
}