using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UniversalDemoApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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
