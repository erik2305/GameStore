using GameStore.Models;
using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property)]
public class YouTubeTrailerAttribute : ValidationAttribute
{
    public string FieldName { get; set; }
    public string Trailer { get; set; }
    /*
    public YouTubeTrailerAttribute(string inputProperty) {
        InputProperty = inputProperty;
        //Trailer = trailer;
    }
    */
    
    public string GetErrorMessge() =>
        $"The {FieldName} field is required to be from YouTube.";

    protected override ValidationResult IsValid(object value, 
        ValidationContext validationContext)
    {
        Game game = (Game)validationContext.ObjectInstance;
        
        if (game.FrenchVersion.Equals(true))
        {
            return new ValidationResult(GetErrorMessge());
        }

        return ValidationResult.Success;
    }
}