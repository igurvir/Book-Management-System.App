using Book_Management_System.Models;

namespace Book_Management_System;

public partial class App : Application
{
    public static List<UserInfo> users =new List<UserInfo>()   {
            
        new UserInfo
        {
            UserName="admin",
            Password="admin",
            Email="admin@gmail.com"
        }

    };
    public static List<Book> books = new List<Book>()
    {
      new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic" },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic" },
            new Book { Title = "1984", Author = "George Orwell", Genre = "Science Fiction" },
            new Book { Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", Genre = "Science Fiction" },
            new Book { Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Genre = "Fantasy" }

    };

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

    }
}
