using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        public const string NAME = @"^[A-Z][a-z]{2,}$";
        public string ValidateFirstName(string firstName)
        {
            Regex regex = new Regex(NAME);
            if (regex.IsMatch(firstName))
                return "Valid";
            return "Invalid";
        }
    }
}