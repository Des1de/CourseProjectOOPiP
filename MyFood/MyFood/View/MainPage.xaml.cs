using MyFood.ViewModel;

namespace MyFood;

public partial class MainPage : ContentPage
{
	
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}



}

