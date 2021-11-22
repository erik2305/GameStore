using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public interface IGamePerspective
    {
        [DisplayName("POV")]
        string Code { get; set; }
        [DisplayName("POV")]
        string EnglishPerspectiveName { get; set; }
        [DisplayName("POV")]
        string FrenchPerspectiveName { get; set; }
    }
}