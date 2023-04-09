using Book_Management_System.ViewModels;

namespace Book_Management_System;

public partial class CreateAccountPage : ContentPage
{
	public CreateAccountPage(CreateAccountPageViewModel account)
	{
		InitializeComponent();       
        this.BindingContext=account;
	}
    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
       await Shell.Current.GoToAsync("//SignIn");
    }
}