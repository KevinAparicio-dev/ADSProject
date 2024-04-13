using System.ComponentModel.DataAnnotations;

namespace ADSProject.Validaciones
{
    public class ValidacionesPersonalizadas : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || value.ToString() == "0")
            {
                return base.IsValid(value, validationContext);
            }
            return ValidationResult.Success;
        }
    }
}
