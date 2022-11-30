
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFood.GlobalConst;
using MyFood.Model;
using MyFood.Services;
using MyFood.View;

namespace MyFood.ViewModel;

public partial class RegistrationViewModel : BaseViewModel
{
    private AccountCreationService accountCreationService; 

    [ObservableProperty]
    string login;

    [ObservableProperty]
    string password;

    [ObservableProperty]
    string rPassword;

    [ObservableProperty]
    string errorMessage;

    public RegistrationViewModel(AccountCreationService accountCreationService)
    {
        this.accountCreationService = accountCreationService;
        Title = "Authorization";
    }

    [RelayCommand]
    async Task CreateAccount()
    {
        IsBusy = true;
        UserInfo accountInfo = await accountCreationService.CreateAccountAsync(Login, Password, RPassword);
        if (accountInfo.ErrorMessage != AccountErrorMessages.SUCCESS)
        {
            IsSuccessful = false;
            ErrorMessage = accountInfo.ErrorMessage;
        }
        else IsSuccessful = true;

        IsBusy = false;
       
    }
}

