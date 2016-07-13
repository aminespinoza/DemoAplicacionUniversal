using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UniversalDemoApp.Views;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UniversalDemoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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
                    txtDeviceFamily.Text = "Mobile mode";
                    break;

                case "Windows.Desktop":
                    btnDesktop.IsEnabled = true;
                    btnMobile.IsEnabled = false;
                    btnIoT.IsEnabled = false;
                    btnXboxOne.IsEnabled = false;
                    txtDeviceFamily.Text = "Desktop mode";
                    break;

                case "Windows.Xbox":
                    btnDesktop.IsEnabled = false;
                    btnMobile.IsEnabled = false;
                    btnIoT.IsEnabled = false;
                    btnXboxOne.IsEnabled = true;
                    txtDeviceFamily.Text = "Xbox mode";
                    break;

                case "Windows.IoT":
                    btnDesktop.IsEnabled = false;
                    btnMobile.IsEnabled = false;
                    btnIoT.IsEnabled = true;
                    btnXboxOne.IsEnabled = false;
                    txtDeviceFamily.Text = "IoT mode";
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
    }
}
