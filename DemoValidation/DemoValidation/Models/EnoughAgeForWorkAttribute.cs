
using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
    public class EnoughAgeForWorkAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var myDate = (DateTime?)value;
            if (myDate.HasValue)
            {
                if (myDate.Value.AddYears(16) > DateTime.Now)
                {
                    return new ValidationResult("Chưa đủ [16] tuổi để làm việc");
                }
                if (myDate.Value.AddYears(65) < DateTime.Now)
                {
                    return new ValidationResult("Quá [65] tuổi để làm việc");
                }
            }
            return ValidationResult.Success;
        }
    }
}