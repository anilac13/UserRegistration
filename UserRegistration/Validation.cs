using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        public const string NAME = @"^[A-Z][a-z]{2,}$";
        public const string EMAIL = @"^[a-zA-z0-9.+-]+[@][a-zA-z0-9]+[.][a-zA-z0-9.]{2,}$";
        public string ValidateFirstName(string firstName)
        {
            Regex regex = new Regex(NAME);
            if (regex.IsMatch(firstName))
                return "Valid";
            return "Invalid";
        }
        public string ValidateLastName(string lastName)
        {
            Regex regex = new Regex(NAME);
            if (regex.IsMatch(lastName))
                return "Valid";
            return "Invalid";
        }
        public string ValidateEmail(string email)
        {
            Regex regex = new Regex(EMAIL);
            if (regex.IsMatch(email))
                return "Valid";
            return "Invalid";
        }
    }
}