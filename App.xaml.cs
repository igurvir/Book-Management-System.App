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
         new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Publisher = "Charles Scribner's Sons",
                PublicationDate = new DateTime(1925, 4, 10),
                ISBN = "978-0-7432-7356-5",
                Genre = "Fiction",
                Summary = "The story primarily concerns the young and mysterious millionaire Jay Gatsby and his quixotic passion and obsession for the beautiful former debutante Daisy Buchanan."
            }

    };

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

    }
}
