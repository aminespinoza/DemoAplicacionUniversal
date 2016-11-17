using System;
using Windows.ApplicationModel.Resources.Core;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UniversalDemoApp.Views
{
    public sealed partial class Holographic : Page
    {
        private SpeechSynthesizer synthesizer;
        private ResourceContext speechContext;
        public Holographic()
        {
            this.InitializeComponent();

            synthesizer = new SpeechSynthesizer();

            speechContext = ResourceContext.GetForCurrentView();
            speechContext.Languages = new string[] { SpeechSynthesizer.DefaultVoice.Language };
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
