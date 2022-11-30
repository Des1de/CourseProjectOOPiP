
using MyFood.Model;

namespace MyFood;

public partial class App : Application
{
    public static User UserAccount { get; set; } = new User();
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
