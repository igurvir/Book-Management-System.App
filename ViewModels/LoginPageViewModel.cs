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
        [ICommand]
        public async void Login()
        {

            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                var user = App.users.FirstOrDefault(u => u.UserName == UserName && u.Password == Password);

                if (user!=null)
                {
                    UserName = "";
                    Password = "";
                    await Shell.Current.GoToAsync("//BookDetail");
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
