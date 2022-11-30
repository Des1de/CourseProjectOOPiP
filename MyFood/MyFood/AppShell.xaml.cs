using MyFood.View;

namespace MyFood;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AuthorizationPage), typeof(AuthorizationPage));
        Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
        Routing.RegisterRoute(nameof(ClientPage), typeof(ClientPage));
        Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
        Routing.RegisterRoute(nameof(DishDetailsPage), typeof(DishDetailsPage));
    }
}

