using GameStore.Models;
using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property)]
public class FrenchVersionAttribute : ValidationAttribute
{
    public string InputProperty { get; }
    public FrenchVersionAttribute(string inputProperty) {
        InputProperty = inputProperty;
    }
    
    public string GetErrorMessge() =>
        $"The {InputProperty} field is required.";

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