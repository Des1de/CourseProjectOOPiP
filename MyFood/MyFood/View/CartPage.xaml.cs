namespace MyFood.View;
using MyFood.ViewModel;

public partial class CartPage : ContentPage
{
	public CartPage(CartViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}