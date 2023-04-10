using Book_Management_System.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.ViewModels
{
    public partial class CreateAccountPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;
        [ObservableProperty]
        private string _Name;
        [ObservableProperty]
        private string _password;
        [ObservableProperty]
        private string _message;

        [ICommand]
        public async void SignUp()
        {
            if(!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrEmpty(Password))
            {
                UserInfo user = new UserInfo
                {
                    Email = Email,
                    UserName = Name,
                    Password =Password
                };
                App.users.Add(user);
                await Shell.Current.GoToAsync("//SignIn");
            }
            else
            {
                Message = "Please provide all feild data!";
            }
        }
    }
}
