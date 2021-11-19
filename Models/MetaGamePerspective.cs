using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public static class MetaGamePerspective
    {
        [DisplayName("POV")]
        public static string Code { get; set; }
        [DisplayName("POV")]
        public static string EnglishPerspectiveName { get; set; }
        [DisplayName("POV")]
        public static string FrenchPerspectiveName { get; set; }
    }
}