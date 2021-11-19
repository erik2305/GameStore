using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public interface IGameCategory
    {
        [DisplayName("Category")]
        int Id { get; set; }
        [DisplayName("Category")]
        string EnglishCategory { get; set; }
        string FrenchCategory { get; set; }
    }
}