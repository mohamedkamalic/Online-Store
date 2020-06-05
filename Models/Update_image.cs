using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OnlineStore.ViewModels;

namespace OnlineStore.Models
{
    public class Update_image : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (ProductFormViewModel) validationContext.ObjectInstance;
            if (product.Id == 0 && product.File == null)
                return new ValidationResult("you must upload image");
            else
                return ValidationResult.Success;
        }
    }
}