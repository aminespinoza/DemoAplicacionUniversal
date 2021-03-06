﻿using System.Threading.Tasks;
using Windows.Devices.Gpio;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UniversalDemoApp.Views
{
    public sealed partial class IoT : Page
    {
        GpioPin led1Pin;
        GpioPin led2Pin;
        GpioPin led3Pin;
        GpioPin led4Pin;

        public IoT()
        {
            this.InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            InitGPIO();
        }

        private void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            led1Pin = gpio.OpenPin(4);
            led1Pin.Write(GpioPinValue.High);
            led1Pin.SetDriveMode(GpioPinDriveMode.Output);

            led2Pin = gpio.OpenPin(17);
            led2Pin.Write(GpioPinValue.High);
            led2Pin.SetDriveMode(GpioPinDriveMode.Output);

            led3Pin = gpio.OpenPin(27);
            led3Pin.Write(GpioPinValue.High);
            led3Pin.SetDriveMode(GpioPinDriveMode.Output);

            led4Pin = gpio.OpenPin(22);
            led4Pin.Write(GpioPinValue.High);
            led4Pin.SetDriveMode(GpioPinDriveMode.Output);
        }

        private void btnLedsSecuence_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                led1Pin.Write(GpioPinValue.High);
                led2Pin.Write(GpioPinValue.Low);
                led3Pin.Write(GpioPinValue.Low);
                led4Pin.Write(GpioPinValue.Low);
                Task.Delay(300).Wait();
                led1Pin.Write(GpioPinValue.Low);
                led2Pin.Write(GpioPinValue.High);
                led3Pin.Write(GpioPinValue.Low);
                led4Pin.Write(GpioPinValue.Low);
                Task.Delay(300).Wait();
                led1Pin.Write(GpioPinValue.Low);
                led2Pin.Write(GpioPinValue.Low);
                led3Pin.Write(GpioPinValue.High);
                led4Pin.Write(GpioPinValue.Low);
                Task.Delay(300).Wait();
                led1Pin.Write(GpioPinValue.Low);
                led2Pin.Write(GpioPinValue.Low);
                led3Pin.Write(GpioPinValue.Low);
                led4Pin.Write(GpioPinValue.High);
                Task.Delay(300).Wait();
            }
        }
    }
}
