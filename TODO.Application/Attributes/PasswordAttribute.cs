using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TODO.Application.Attributes
{
    public class PasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var strValue = value as string;
            if (string.IsNullOrWhiteSpace(strValue))
            {
                return new ValidationResult("Password Is Required");
            }
            if (strValue.Length < 8)
            {
                return new ValidationResult("Password Must Be At Least 8 Characters");
            }

            if (!strValue.Any(char.IsDigit))
            {
                return new ValidationResult("Password Must Contain At Least 1 Digit");
            }

            if (!strValue.Any(char.IsLower))
            {
                return new ValidationResult("Password Must Contain At Least 1 Lower Case Character");
            }

            return strValue.Any(char.IsUpper) ? ValidationResult.Success : 
                new ValidationResult("Password Must Contain At Least 1 Upper Case Character");
        }
    }
}