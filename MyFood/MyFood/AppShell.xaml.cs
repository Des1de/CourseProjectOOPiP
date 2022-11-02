using MyFood.View;

namespace MyFood;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(RegestrationPage), typeof(RegestrationPage));
        Routing.RegisterRoute(nameof(ClientPage), typeof(ClientPage));
    }
}
