using System;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UniversalDemoApp.Views
{
    public sealed partial class XboxOne : Page
    {
        public XboxOne()
        {
            this.InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private async void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog message = new MessageDialog("Hola desde Xbox!!");
            await message.ShowAsync();
        }

        private async void btnWebSite_Click(object sender, RoutedEventArgs e)
        {
            var success = await Launcher.LaunchUriAsync(new Uri(@"http://aminespinoza.com"));
        }
    }
}
