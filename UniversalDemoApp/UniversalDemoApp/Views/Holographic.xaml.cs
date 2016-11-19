using System;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UniversalDemoApp.Views
{
    public sealed partial class Holographic : Page
    {
        private SpeechSynthesizer synthesizer;

        public Holographic()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            synthesizer = new SpeechSynthesizer();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private async void btnSpeak_Click(object sender, RoutedEventArgs e)
        {
            string text = "Hello world from this awesome device called Hololens";

            SpeechSynthesisStream synthesisStream = await synthesizer.SynthesizeTextToStreamAsync(text);

            media.AutoPlay = true;
            media.SetSource(synthesisStream, synthesisStream.ContentType);
            media.Play();

        }

        void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            //btnSpeak.Content = "Speak";
        }
    }
}
