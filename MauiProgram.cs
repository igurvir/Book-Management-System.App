﻿using Book_Management_System.ViewModels;
using Microsoft.Extensions.Logging;

namespace Book_Management_System;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<CreateAccountPage>();
        builder.Services.AddSingleton<CreateAccountPageViewModel>();
        builder.Services.AddSingleton<BookDetail>();
        builder.Services.AddSingleton<BookDetailViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
