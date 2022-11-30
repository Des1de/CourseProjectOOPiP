using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace MyFood.Model
{
    public partial class User : ObservableObject
    {
        [ObservableProperty]
        bool _isSignedIn;

        public string UserName { get; set; }

        public User()
        {
            IsSignedIn = false;
            UserName = null;
            PropertyChanged += SignedIn;
        }

        void SignedIn(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != nameof(IsSignedIn)) return;
        }
    }
}
