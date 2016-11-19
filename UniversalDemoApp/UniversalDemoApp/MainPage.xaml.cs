using UniversalDemoApp.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UniversalDemoApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string familyDevice = Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily;

            switch (familyDevice)
            {
                case "Windows.Mobile":
                    btnDesktop.IsEnabled = false;
                    btnMobile.IsEnabled = true;
                    btnIoT.IsEnabled = false;
                    btnXboxOne.IsEnabled = false;
                    btnHolographic.IsEnabled = false;
                    txtDeviceFamily.Text = "Mobile mode";
                    break;

                case "Windows.Desktop":
                    btnDesktop.IsEnabled = true;
                    btnMobile.IsEnabled = false;
                    btnIoT.IsEnabled = false;
                    btnXboxOne.IsEnabled = false;
                    btnHolographic.IsEnabled = false;
                    txtDeviceFamily.Text = "Desktop mode";
                    break;

                case "Windows.Xbox":
                    btnDesktop.IsEnabled = false;
                    btnMobile.IsEnabled = false;
                    btnIoT.IsEnabled = false;
                    btnXboxOne.IsEnabled = true;
                    btnHolographic.IsEnabled = false;
                    txtDeviceFamily.Text = "Xbox mode";
                    break;

                case "Windows.IoT":
                    btnDesktop.IsEnabled = false;
                    btnMobile.IsEnabled = false;
                    btnIoT.IsEnabled = true;
                    btnXboxOne.IsEnabled = false;
                    btnHolographic.IsEnabled = false;
                    txtDeviceFamily.Text = "IoT mode";
                    break;

                case "Windows.Holographic":
                    btnDesktop.IsEnabled = false;
                    btnMobile.IsEnabled = false;
                    btnIoT.IsEnabled = false;
                    btnXboxOne.IsEnabled = false;
                    btnHolographic.IsEnabled = true;
                    txtDeviceFamily.Text = "Holo mode";
                    break;
            }
        }

        private void btnMobile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Mobile));
        }

        private void btnDesktop_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Desktop));
        }

        private void btnIoT_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IoT));
        }

        private void btnXboxOne_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(XboxOne));
        }

        private void btnHolographic_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Holographic));
        }
    }
}
