using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW___3___Builder
{
    public class UserBuilder : IUserBuilder
    {
        private User _user = null!;

        public UserBuilder(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentNullException(nameof(firstName), "First name is required.");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException(nameof(lastName), "Last name is required.");

            _user = new User
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        public IUserBuilder AddMiddleName(string? middleName)
        {
            _user.MiddleName = middleName;
            return this;
        }

        public IUserBuilder AddBirthdate(DateTime? birthdate)
        {
            _user.Birthdate = birthdate;
            return this;
        }

        public IUserBuilder AddPhone(string? phone)
        {
            _user.Phone = phone;
            return this;
        }

        public IUserBuilder AddAddress(string? address)
        {
            _user.Address = address;
            return this;
        }

        public IUserBuilder AddEmail(string? email)
        {
            _user.Email = email;
            return this;
        }

        public User Build()
        {
            var validator = new UserValidator();
            var validationResults = validator.Validate(_user);
            if (validationResults.Any())
            {
                throw new InvalidOperationException("User validation failed: " + string.Join(", ", validationResults));
            }
            return _user;
        }

    }
}
