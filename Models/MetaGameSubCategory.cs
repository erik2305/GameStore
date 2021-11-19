using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public static class MetaGameSubCategory
    {
        [DisplayName("Sub Category")]
        public static int Id { get; set; }
        public static int GameCategoryId { get; set; }
        [DisplayName("Sub Category")]
        public static string EnglishCategory { get; set; }
        public static string FrenchCategory { get; set; }
    }
}