using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UniversalDemoApp.Views
{
    public sealed partial class Mobile : Page
    {
        public Mobile()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            e.Handled = true;
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void btnOpenPeopleApp_Click(object sender, RoutedEventArgs e)
        {
            var success = await Launcher.LaunchUriAsync(new Uri("ms-people:"));
        }
    }
}
