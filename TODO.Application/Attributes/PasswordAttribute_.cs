using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TODO.Application.Attributes
{
    public class PasswordAttribute_ : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var strValue = value as string;
            var errorMessage = "";
            if (string.IsNullOrWhiteSpace(strValue))
            {
                if (strValue.Length < 8)
                {
                    if (strValue.Any(char.IsDigit))
                    {
                        if (strValue.Any(char.IsLower))
                        {
                            if (strValue.Any(char.IsUpper))
                            {
                                return ValidationResult.Success;
                            }

                            errorMessage = "Password Must Contain At Least 1 Upper Case Character";
                        }
                        else
                        {
                            errorMessage = "Password Must Contain At Least 1 Lower Case Character";
                        }
                    }
                    else
                    {
                        errorMessage = "Password Must Contain At Least 1 Digit";
                    }
                }
                else
                {
                    errorMessage = "Password Must Be At Least 8 Characters";
                }
            }
            else
            {
                errorMessage = "Password Is Required";
            }

            return new ValidationResult(errorMessage);
        }
    }
}