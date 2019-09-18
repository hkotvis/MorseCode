using System;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        private static string[] codes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };
        private static char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };

        public MainPage()
        {
            InitializeComponent();
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

        void OnDotClicked(object sender, EventArgs e)
        {

            entry.Text += ".";
        }


        void OnDashClicked(object sender, EventArgs e)
        {
            entry.Text += "-";
        }

        void OnSpaceClicked(object sender, EventArgs e)
        {
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].Equals(entry.Text))
                {
                    entryLetter.Text += letters[i];
                    break;
                }
            }
            entry.Text = "";
        }
    }
}
