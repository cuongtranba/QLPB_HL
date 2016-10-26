using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _4.Helper
{
    public static class ValidationExtention
    {
        public static ValidationModel ModelState(this object model)
        {
            var validationContext = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();
            var modelState = new ValidationModel
            {
                IsValid = Validator.TryValidateObject(model, validationContext, results, true),
                ErrorMessages = results
            };
            return modelState;
        }
    }
}
