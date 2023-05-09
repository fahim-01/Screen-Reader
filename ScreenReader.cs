using System.Speech.Synthesis;
using System.Windows.Forms;


namespace ScreenReaderProject
{
    class ScreenReader
    {
        private readonly SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public ScreenReader()
        {
            synthesizer.SetOutputToDefaultAudioDevice();
        }

        public void ReadText(string text)
        {
            synthesizer.SpeakAsync(text);
        }
    }
}



