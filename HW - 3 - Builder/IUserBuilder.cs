using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW___3___Builder
{
    public interface IUserBuilder
    {
        IUserBuilder AddMiddleName(string? middleName);
        IUserBuilder AddBirthdate(DateTime? birthdate);
        IUserBuilder AddPhone(string? phone);
        IUserBuilder AddAddress(string? address);
        IUserBuilder AddEmail(string? email);

        User Build();
    }

    
}
