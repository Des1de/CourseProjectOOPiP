using CommunityToolkit.Mvvm.ComponentModel;

namespace MyFood.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string _title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool _isBusy;
        public bool IsNotBusy => !_isBusy;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotSuccessful))]
        bool isSuccessful = false;
        public bool IsNotSuccessful => !isSuccessful;

        [ObservableProperty]
        public bool isFailed = false;
    }
}
