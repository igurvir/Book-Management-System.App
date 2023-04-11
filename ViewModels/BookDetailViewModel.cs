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
    public partial class BookDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<Book> _book;
        public BookDetailViewModel() {
            Book = App.books;
        }
        [ICommand]
        private async Task LoadBooks()
        {
            IsBusy = true;
            Book = App.books;
        }
        [ICommand]
        private async Task Logout()
        {
            await Shell.Current.GoToAsync("//SignIn");
        }
    }
}
