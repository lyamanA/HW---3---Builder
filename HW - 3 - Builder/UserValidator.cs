using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW___3___Builder
{
    public class UserValidator
    {
        public IEnumerable<string> Validate(User user)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                errors.Add("First name is required.");
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                errors.Add("Last name is required.");
            }

            if (!string.IsNullOrWhiteSpace(user.Email) && !IsValidEmail(user.Email))
            {
                errors.Add("Invalid email format.");
            }

            if (!string.IsNullOrWhiteSpace(user.Phone) && !IsValidPhone(user.Phone))
            {
                errors.Add("Invalid phone number format.");
            }

            return errors;
        }

        // \s - любой пробельный символ
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Простое регулярное выражение для проверки формата email
            string pattern = @"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private bool IsValidPhone(string phone)
        {
            return phone.All(char.IsDigit);
        }
    }
}
