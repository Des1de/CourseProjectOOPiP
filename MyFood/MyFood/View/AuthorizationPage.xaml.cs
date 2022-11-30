using MyFood.ViewModel;

namespace MyFood;

public partial class AuthorizationPage : ContentPage
{
	public AuthorizationPage(AuthorizationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

