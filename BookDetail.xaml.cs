using Book_Management_System.ViewModels;

namespace Book_Management_System;

public partial class BookDetail : ContentPage
{
	public BookDetail()
	{
		InitializeComponent();
        var viewModel = new BookDetailViewModel();
    }
}