using MyFood.ViewModel;

namespace MyFood.View;

public partial class DishDetailsPage : ContentPage
{
	public DishDetailsPage(DishDetailsViewModel vm)
	{

		InitializeComponent();
        BindingContext = vm;
    }
}