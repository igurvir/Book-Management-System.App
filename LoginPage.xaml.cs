using Book_Management_System.ViewModels;

namespace Book_Management_System;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();

		this.BindingContext = loginPageViewModel;

	}
    private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CreateAccountPage");
    }

}