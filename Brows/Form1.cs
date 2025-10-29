namespace Brows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            System.Uri url = new Uri(textBox1.Text);
            webView21.Source = url;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strippedUrl = textBox1.Text.Substring(8);
            comboBoxFavorieten.Items.Add(strippedUrl);
        }

        private void comboBoxFavorieten_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb1 = sender as ComboBox;
            string url = "https://" + cb1.SelectedItem.ToString();
            System.Uri uri = new Uri(url);
            webView21.Source = uri;
            textBox1.Text = url;
        }

        private void buttonSuggesties_Click(object sender, EventArgs e)
        {
            // Kijk zo doe je dat als je je eigen content will weergeven in de browser.
            // Je gebruikt dan de webView21.NavigateToString() property van de webview. De string tussen de () wordt dan in de browser
            // weergegeven. In die string kun je ook html elementen zoals <br> schrijven. <br> is het html element om een break te maken zodat
            // de rest van de string op een nieuwe regel wordt weergegeven. 
            string suggesties = @"
                Suggesties voor een portfolio desktop app die de browser control webview2 gebruikt om:<br>
                muziek of podcasts af te spelen (radio app)<br>
                een browser te maken met de styling van je fav voetbalclub.<br>
                een browser te maken die je leeromgeving is met links naar tutorials, repo's vscode online etc.<br>
                een browser te maken gericht op je hobby 
                ";
            webView21.NavigateToString(suggesties);
        }
    }

    public class Form2 : Form1
    {
        public Form2()
        {
            //Form2 form2 = new Form2();
            //form2.Show();
            this.Size = new System.Drawing.Size(555, 555);
        }
    }
}
