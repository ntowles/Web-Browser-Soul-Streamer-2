using System.Media;

namespace SoulStream2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFlowOn_Click(object sender, EventArgs e)
        {

            //Selecting the sound to play when I clck the go button
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Produce_a_drum_fill_with_toms_and_snares__leading_into_a_hip_hop_beat_drop_);
            //Play a sound when I click the Flow On button
            soundPlayer.Play();
            // When user click the "Flow On" button they are raising an event.
            // I will write code to handle the event.
            // First, I will get the URL from the address bar that the user typed in.
            string url = textBoxAddressBar.Text;

            //Lets check the string the user typed in and fix the most common errors
            // as a service to our users. This imporves the UX.
            // Check if the user forget to type in the prefix "http:" or "https:"
            if (!url.StartsWith("http://"))
            {
                // If missing, we will add "https://" as default for them
                url = "https://" + url;
            }
            // Chec if the user let the address bar blank
            if (textBoxAddressBar.Text == string.Empty.Trim())
            {
                // Put up a message box to inform the user
                MessageBox.Show("Pathway to Nowhere! Please type URL into address bar.", "Craving Details!");

            }
            //Now if all checks are passed, we can navigate to the URL in the address bar.
            else
            {
                webView21Main.CoreWebView2.Navigate(url);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
         
        }
    }
}
