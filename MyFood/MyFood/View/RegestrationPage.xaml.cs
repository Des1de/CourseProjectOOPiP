using MyFood.ViewModel;

namespace MyFood.View;

public partial class RegestrationPage : ContentPage
{
	public RegestrationPage(RegestrationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; 
	}
}