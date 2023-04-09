using Book_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.Services
{
    public class UserService : IUserRepository
    {
        private List<UserInfo> list = new List<UserInfo>
        {
            new UserInfo
            {
                UserName="Ramesh",
                Password="1234",
                Email="ramesh@gmail.com"
            }
        };
        public bool Login(string username, string password)
        {
            var isSuccess = list.Any(x => x.UserName == username && x.Password == password);

            if (isSuccess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SignUp(UserInfo user)
        {
            if (user!=null)
            {
                list.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
