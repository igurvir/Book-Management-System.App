using Book_Management_System.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;
        [ObservableProperty]
        private string _message;
        readonly IUserRepository loginRepository = new UserService();
        [ICommand]
        public async void Login()
        {

            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                bool isSuccess = loginRepository.Login(UserName, Password);
                if (isSuccess)
                {
                    UserName = "";
                    Password = "";
                    Message = "Success!";
                }
                else
                {
                    UserName = "";
                    Password = "";
                    Message = "Incorrect username or password!";
                }
                    

            }
        }
    }
}
