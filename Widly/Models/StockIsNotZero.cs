using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Widly.Models
{
    public class StockIsNotZero : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock >= 0 || movie.NumberInStock <= 20)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Enter a valid stock between 1 and 20.");
            }
        }
    }
}