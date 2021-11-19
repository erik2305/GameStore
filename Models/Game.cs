//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStore.Models
{
    using GameStore.Validators;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Game : IGame
    {
        // better youtube checker 
        // https://webapps.stackexchange.com/questions/13854/are-youtube-codes-guaranteed-to-always-be-11-characters
        private const string youtubeRegex = @"^(https:\/\/www\.youtube\.com\/watch\?v=\w+)|^(https:\/\/www\.youtube\.com\/embed\/\w+)|^(https:\/\/youtu\.be\/\w+)";
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            this.GameEsrbContentDescriptors = new HashSet<GameEsrbContentDescriptor>();
            this.Products = new HashSet<Product>();
        }
        [ScaffoldColumn(false)]
        [Required]
        public System.Guid Guid { get; set; }
        [Required]
        [RegularExpression("A|D|P", ErrorMessage = "Game must availability must be selected.")]
        [DisplayName("Availability")]
        public string GameStatusCode { get; set; }
        [Required]
        [DisplayName("Category")]
        public int GameCategoryId { get; set; }
        [DisplayName("Sub Category")]
        public Nullable<int> GameSubCategoryId { get; set; }
        [Required]
        [DisplayName("ESRB")]
        public string EsrbRatingCode { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        [DisplayName("English Name")]
        public string EnglishName { get; set; }
        [FrenchVersion("French Name")]
        [DisplayName("French Name")]
        public string FrenchName { get; set; }
        [Required]
        [DisplayName("French?")]
        public bool FrenchVersion { get; set; }
        [Required]
        [DisplayName("Player Count")]
        public string EnglishPlayerCount { get; set; }
        [ScaffoldColumn(false)]
        public string FrenchPlayerCount { get; set; }
        [Required]
        [DisplayName("POV")]
        public string GamePerspectiveCode { get; set; }
        [Required]
        [RegularExpression(pattern: MyRegex.NotYoutubeRegex, ErrorMessage = "Youtube links only please")]
        [DisplayName("English Trailer")]
        public string EnglishTrailer { get; set; }
        [FrenchVersion("French Trailer")]
        [RegularExpression(pattern: MyRegex.NotYoutubeRegex, ErrorMessage = "Youtube links only please")]
        [DisplayName("French Trailer")]
        public string FrenchTrailer { get; set; }
        [Required]
        [DisplayName("English Description")]
        public string EnglishDescription { get; set; }
        [FrenchVersion("French Description")]
        [DisplayName("French Description")]
        public string FrenchDescription { get; set; }
        [Required]
        [DisplayName("English Detail")]
        public string EnglishDetail { get; set; }
        [FrenchVersion("French Detail")]
        [DisplayName("French Detail")]
        public string FrenchDetail { get; set; }
        [Required]
        [DisplayName("Submitter")]
        public string UserName { get; set; }
        public virtual EsrbRating EsrbRating { get; set; }
        public virtual GameCategory GameCategory { get; set; }
        public virtual GamePerspective GamePerspective { get; set; }
        public virtual GameStatu GameStatu { get; set; }
        public virtual GameSubCategory GameSubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameEsrbContentDescriptor> GameEsrbContentDescriptors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
