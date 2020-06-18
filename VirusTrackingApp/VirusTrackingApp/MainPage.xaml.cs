using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Application = Xamarin.Forms.Application;

namespace VirusTrackingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PropertyChanged += ContentPageBase_PropertyChanged;
        }
        
        private void ContentPageBase_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SafeAreaInsets")
            {
                var safeAreaInsets = On<iOS>().SafeAreaInsets();
                Application.Current.Resources["SafeAreaInsets"] = safeAreaInsets;
            }
        }
    }
}