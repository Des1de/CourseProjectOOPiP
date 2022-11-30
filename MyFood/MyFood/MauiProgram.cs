using MyFood.View;
using MyFood.ViewModel;
using CommunityToolkit.Maui;
using MyFood.Services;

namespace MyFood;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<AuthorizationPage>();
        builder.Services.AddTransient<AuthorizationViewModel>();


        builder.Services.AddTransient<RegistrationPage>();
        builder.Services.AddTransient<RegistrationViewModel>();

        builder.Services.AddTransient<ClientPage>();
        builder.Services.AddTransient<ClientViewModel>();

        builder.Services.AddTransient<CartPage>();
        builder.Services.AddTransient<CartViewModel>();

        builder.Services.AddTransient<DishDetailsPage>();
        builder.Services.AddTransient<DishDetailsViewModel>();

        builder.Services.AddSingleton<AuthorizationService>();
        builder.Services.AddSingleton<AccountCreationService>();
        builder.Services.AddSingleton<DishService>();
        builder.Services.AddSingleton<CartService>();
        return builder.Build();
	}
}
