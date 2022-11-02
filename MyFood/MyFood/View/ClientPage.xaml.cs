using MyFood.ViewModel;

namespace MyFood.View;

public partial class ClientPage : ContentPage
{
	public ClientPage(ClientViewModel vm)
	{

		InitializeComponent();
		BindingContext = vm;
	}
}