using System.Text.RegularExpressions;
using Common.Domain.Exceptions;
using ValueOf;

namespace Common.Domain.Value_Objects
{
    public class Email : ValueOf<string, Email>
    {
        private const string EmailRegexFormat = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        
        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Value)) throw new InvalidEmailException(Value);
            var regex = new Regex(EmailRegexFormat);
            if (!regex.IsMatch(Value)) throw new InvalidEmailException(Value);
            
        }
    }
}