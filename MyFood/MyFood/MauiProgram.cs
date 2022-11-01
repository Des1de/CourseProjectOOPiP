using MyFood.View;
using MyFood.ViewModel;
using CommunityToolkit.Maui;

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

		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();


        builder.Services.AddTransient<RegestrationPage>();
        builder.Services.AddTransient<RegestrationViewModel>();

        return builder.Build();
	}
}
