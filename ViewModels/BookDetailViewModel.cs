using Book_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.ViewModels
{
    public partial class BookDetailViewModel: BaseViewModel
    {
        public List<Book> Books { get; set; }
        public BookDetailViewModel() {
        Books = new List<Book>
        {
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic" },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic" },
            new Book { Title = "1984", Author = "George Orwell", Genre = "Science Fiction" },
            new Book { Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", Genre = "Science Fiction" },
            new Book { Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Genre = "Fantasy" }
        };
        }
    }
}
