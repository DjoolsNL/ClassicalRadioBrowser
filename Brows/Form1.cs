using Microsoft.VisualBasic;
using System.Data;
using System.Xml.Linq;

namespace Brows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetFavoritesForBrowser();
            SetFavoritesForSettings();
            SetPopertiesSettingsDefault();
        }

        // ////////////////////////// Browser ///////////////////////////////////////////////
        /// <summary>
        /// navigate to source
        /// </summary>
        private void ToolStripButtonGoTo_Click(object sender, EventArgs e)
        {
            if (IsValidUri(toolStripTextBoxUrl.Text))
            {
                System.Uri uri = new Uri(toolStripTextBoxUrl.Text);
                webView21.Source = uri;
            }
            else
            {
                MsgInvalidUrl();
            }
        }

        /// <summary>
        /// navigate to source
        /// </summary>
        private void ToolStripTextBoxUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs ee = new EventArgs();
                // we reuse an existing method 
                ToolStripButtonGoTo_Click(sender, ee);
            }
        }

        /// <summary>
        /// navigate to source 
        /// </summary>
        private void ToolStripComboBoxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox? tscbFavorieten = sender as ToolStripComboBox;

            string url = $"https://{tscbFavorieten!.SelectedItem}";

            if (IsValidUri(url))
            {
                System.Uri uurl = new Uri(url);
                webView21.Source = uurl;
                toolStripTextBoxUrl.Text = url;
            }
            else
            {
                MsgInvalidUrl();
            }
        }

        /// <summary>
        /// Add new url to Favorites.
        /// </summary>
        private void ToolStripButtonAddToFav_Click(object sender, EventArgs e)
        {
            if (IsValidUri(toolStripTextBoxUrl.Text))
            {
                string strippedUrl = toolStripTextBoxUrl.Text.Substring(8);
                Properties.Settings.Default.favorites.Add(strippedUrl);
                Properties.Settings.Default.Save();

                toolStripComboBoxFavorites.Items.Clear();
                SetFavoritesForBrowser();
            }
            else
            {
                MsgInvalidUrl();
            }
        }

        /// <summary>
        /// Display current url in the toolStripTextBox
        /// </summary>
        private void WebView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            toolStripTextBoxUrl.Text = webView21.Source.ToString();
        }


        ////////////////////////////// Settings ///////////////////////////////////////////////////
        /// <summary>
        /// Toggle between webView21 and Settings.
        /// </summary>
        private void ToolStripButtonSettings_Click(object sender, EventArgs e)
        {
            if (webView21.Visible == false)
            {
                webView21.Visible = true;
                flowLayoutPanel1.Visible = false;
                toolStripButtonSettings.ToolTipText = "Settings";
            }
            else
            {
                webView21.Visible = false;
                flowLayoutPanel1.Visible = true;
                toolStripButtonSettings.ToolTipText = "Back to browser";
                flowLayoutPanel1.Controls.Clear();
                PopulateFlowLayoutPanelFavorites();
            }
        }

        private void TextBoxFavorites_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using TextBox? tb = sender as TextBox;
                Properties.Settings.Default.favorites[(int)tb!.Tag!] = tb.Text.Trim();
                Properties.Settings.Default.Save();

                toolStripComboBoxFavorites.Items.Clear();
                SetFavoritesForBrowser();
                flowLayoutPanel1.Controls.Clear();
                PopulateFlowLayoutPanelFavorites();
            }
        }

        private void ButtonApplyZoomFactor_Click(object sender, EventArgs e)
        {
            webView21.ZoomFactor = (double)numericUpDown1.Value / 100;
            Properties.Settings.Default.zoomfactor = (double)numericUpDown1.Value;
            Properties.Settings.Default.Save();
            webView21.Reload();
        }

        private void ButtonSetAppName_Click(object sender, EventArgs e)
        {
            this.Text = textBoxAppName.Text;
            Properties.Settings.Default.appName = textBoxAppName.Text;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSetingsFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? cbFavorieten = sender as ComboBox;
            string url = $"https://{cbFavorieten!.SelectedItem}";

            if (IsValidUri(url))
            {
                System.Uri uri = new Uri(url);
                webView21.Source = uri;
                toolStripTextBoxUrl.Text = url;
                Properties.Settings.Default.startUpIndex = cbFavorieten.SelectedIndex;
                Properties.Settings.Default.Save();
            }
            else
            {
                MsgInvalidUrl();
            }
        }
    }
}
