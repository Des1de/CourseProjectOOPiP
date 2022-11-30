using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFood.GlobalConst;
using MyFood.Model;
using MyFood.Services;
using MyFood.View;

namespace MyFood.ViewModel;

public partial class AuthorizationViewModel : BaseViewModel
{
    [ObservableProperty]
    string login;
    [ObservableProperty]
    string password;

    [ObservableProperty]
    string errorMessage;
    
    private AuthorizationService authorizationService;

    [RelayCommand]
    async Task SignUp(string s)
    {
        await Shell.Current.GoToAsync(nameof(RegistrationPage));
    }

    [RelayCommand]
    async Task SignIn(string s)
    {
        IsBusy = true;
        UserInfo accountInfo = await authorizationService.DoAuthorizationAsync(Login, Password);
        if (accountInfo.ErrorMessage == AccountErrorMessages.SUCCESS)
        {
            IsSuccessful = true;
            App.UserAccount.UserName = Login;
            App.UserAccount.IsSignedIn = true;
            IsFailed = false;
            await Shell.Current.GoToAsync(nameof(ClientPage));
        }
        else
        {
            IsSuccessful = false;
            ErrorMessage = accountInfo.ErrorMessage;
            IsFailed = true;
            Password = string.Empty;
        }
        IsBusy = false;
        
    }

    public AuthorizationViewModel(AuthorizationService authorizationService)
    {
        this.authorizationService = authorizationService;
        Title = "Authorization";
    }
}

