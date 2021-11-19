using GameStore.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    interface IGame
    {
        // better youtube checker 
        // https://webapps.stackexchange.com/questions/13854/are-youtube-codes-guaranteed-to-always-be-11-characters
        // private const string youtubeRegex = @"^(https:\/\/www\.youtube\.com\/watch\?v=\w+)|^(https:\/\/www\.youtube\.com\/embed\/\w+)|^(https:\/\/youtu\.be\/\w+)";

        [ScaffoldColumn(false)]
        [Required]
        System.Guid Guid { get; set; }
        [Required]
        [RegularExpression("A|D|P", ErrorMessage = "Game must availability must be selected.")]
        [DisplayName("Availability")]
        string GameStatusCode { get; set; }
        [Required]
        [DisplayName("Category")]
        int GameCategoryId { get; set; }
        [DisplayName("Sub Category")]
        Nullable<int> GameSubCategoryId { get; set; }
        [Required]
        [DisplayName("ESRB")]
        string EsrbRatingCode { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        [DisplayName("English Name")]
        string EnglishName { get; set; }
        [FrenchVersion("French Name")]
        [DisplayName("French Name")]
        string FrenchName { get; set; }
        [Required]
        [DisplayName("French?")]
        bool FrenchVersion { get; set; }
        [Required]
        [DisplayName("Player Count")]
        string EnglishPlayerCount { get; set; }
        [ScaffoldColumn(false)]
        string FrenchPlayerCount { get; set; }
        [Required]
        [DisplayName("POV")]
        string GamePerspectiveCode { get; set; }
        [Required]
        [RegularExpression(pattern: MyRegex.NotYoutubeRegex, ErrorMessage = "Youtube links only please")]
        [DisplayName("English Trailer")]
        string EnglishTrailer { get; set; }
        [FrenchVersion("French Trailer")]
        [RegularExpression(pattern: MyRegex.NotYoutubeRegex, ErrorMessage = "Youtube links only please")]
        [DisplayName("French Trailer")]
        string FrenchTrailer { get; set; }
        [Required]
        [DisplayName("English Description")]
        string EnglishDescription { get; set; }
        [FrenchVersion("French Description")]
        [DisplayName("French Description")]
        string FrenchDescription { get; set; }
        [Required]
        [DisplayName("English Detail")]
        string EnglishDetail { get; set; }
        [FrenchVersion("French Detail")]
        [DisplayName("French Detail")]
        string FrenchDetail { get; set; }
        [Required]
        [DisplayName("Submitter")]
        string UserName { get; set; }
    }
}