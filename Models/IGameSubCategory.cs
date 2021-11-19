using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public interface IGameSubCategory
    {
        [DisplayName("Sub Category")]
        int Id { get; set; }
        int GameCategoryId { get; set; }
        [DisplayName("Sub Category")]
        string EnglishCategory { get; set; }
        string FrenchCategory { get; set; }
    }
}