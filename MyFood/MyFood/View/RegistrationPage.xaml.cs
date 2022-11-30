using MyFood.ViewModel;

namespace MyFood.View;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage(RegistrationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; 
	}
}