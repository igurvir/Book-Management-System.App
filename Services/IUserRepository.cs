using Book_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.Services
{
    interface IUserRepository
    {
        bool Login(string username, string password);
        bool SignUp(UserInfo user);
    }
}
