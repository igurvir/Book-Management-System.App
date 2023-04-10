using Book_Management_System.ViewModels;

namespace Book_Management_System;

public partial class BookDetail : ContentPage
{
	public BookDetail(BookDetailViewModel book)
	{
		InitializeComponent();
        this.BindingContext = book;
    }
}