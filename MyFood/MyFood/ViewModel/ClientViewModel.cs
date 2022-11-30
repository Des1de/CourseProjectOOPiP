
using MyFood.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFood.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MyFood.View;

namespace MyFood.ViewModel;

[QueryProperty(nameof(Title), nameof(Title))]
[QueryProperty(nameof(Dishes), nameof(Dishes))]
public partial class ClientViewModel : BaseViewModel
{
    readonly DishService _dishService;
    [RelayCommand]
    async Task Cart(string s)
    {
        await Shell.Current.GoToAsync(nameof(CartPage));
    }

    [ObservableProperty]
    ObservableCollection<Dish> dishes;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotEmpty))]
    bool isEmpty = true;
    public bool IsNotEmpty => !isEmpty;

    public void CollectionChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(Dishes)) return;
        if (Dishes.Count == 0) IsEmpty = true;
        else IsEmpty = false;
    }

    public ClientViewModel(DishService dishService)
    {
        _dishService = dishService;

        PropertyChanged += CollectionChanged;
        dishes = new(_dishService.GetProducts()); 
    }

    [RelayCommand]
    async Task GoToProduct(Dish currentDish)
    {
        await Shell.Current.GoToAsync($"{nameof(DishDetailsPage)}",
            new Dictionary<string, object>
            {
                ["CurrentDish"] = currentDish
            });
    }
}

