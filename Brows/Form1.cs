namespace Brows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // navigate to source after clicking magnifier button
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Uri url = new Uri(toolStripTextBox1.Text);
            webView21.Source = url;
        }

        // De gekozen optie wordt voorzien van een https:// en die wordt als link aan webview21 gegeven
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox? tscbFavorieten = sender as ToolStripComboBox;
            string url = $"https://{tscbFavorieten!.SelectedItem}";
            System.Uri uri = new Uri(url);
            webView21.Source = uri;
            toolStripTextBox1.Text = url;
            this.Focus();
        }

        /// <summary>
        /// Content of toolStripTextBox1 is being added to comboBoxFavorieten
        /// </summary>
        /// <param name="sender">control that has called this method</param>
        /// <param name="e">bunch of event-specific data</param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string strippedUrl = toolStripTextBox1.Text.Substring(8);
            toolStripComboBox1.Items.Add(strippedUrl);
        }

        // navigate to source after key enter
        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Uri url = new Uri(toolStripTextBox1.Text);
                webView21.Source = url;
            }
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            toolStripTextBox1.Text = webView21.Source.ToString();
        }

        // toggle between webview and settings
        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            if (webView21.Visible == false)
            {
                webView21.Visible = true;
                toolStripButtonSettings.ToolTipText = "Settings";
            }
            else
            {
                webView21.Visible = false;
                toolStripButtonSettings.ToolTipText = "Back to browser";

                // code voor settings
            }
        }

        private void buttonApplyZoomFactor_Click(object sender, EventArgs e)
        {
            webView21.ZoomFactor = (double)numericUpDown1.Value/100;
            Properties.Settings.Default.zoomfactor = (double)numericUpDown1.Value;
            Properties.Settings.Default.Save();
            webView21.Reload();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = (decimal)Properties.Settings.Default.zoomfactor;
            webView21.ZoomFactor = Properties.Settings.Default.zoomfactor/100;
        }
    }
}
