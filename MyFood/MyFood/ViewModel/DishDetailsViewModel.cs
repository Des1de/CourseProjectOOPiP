using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFood.Model;
using MyFood.Services;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
namespace MyFood.ViewModel
{
    [QueryProperty(nameof(CurrentDish), nameof(CurrentDish))]
    public partial class DishDetailsViewModel : BaseViewModel
    {
        readonly CartService _cartService;

        [ObservableProperty]
        Dish _currentDish;

        public DishDetailsViewModel(CartService cartService)
        {
            _cartService = cartService;
           
           
        }
        [RelayCommand]
        async Task AddToCart(Dish dish)
        {
            List<Dish> newCartList = await _cartService.AddProduct(dish);
            
        }

    }
}
