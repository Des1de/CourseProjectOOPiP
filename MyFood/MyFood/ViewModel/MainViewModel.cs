using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFood.View;

namespace MyFood.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string login;
    [ObservableProperty]
    string password;


    [RelayCommand]
    async Task Regestration(string s)
    {
        await Shell.Current.GoToAsync(nameof(RegestrationPage));
    }
}

