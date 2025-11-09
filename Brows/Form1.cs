using Microsoft.VisualBasic;
using System.Data;
using System.Security.Policy;
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
        /// navigate webView1 to source
        /// </summary>
        private void ToolStripButtonGoTo_Click(object sender, EventArgs e)
        {
            if (IsValidUri(toolStripTextBoxUrl.Text))
            {
                System.Uri uri = new Uri(toolStripTextBoxUrl.Text);
                webView1.Source = uri;
            }
            else
            {
                MsgInvalidUrl();
            }
        }

        /// <summary>
        /// navigate webView1 to source
        /// </summary>
        private void ToolStripTextBoxUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs ee = new EventArgs();
                ToolStripButtonGoTo_Click(sender, ee);
            }
        }

        /// <summary>
        /// navigate webView1 to source 
        /// </summary>
        private void ToolStripComboBoxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox? tscbFavorieten = sender as ToolStripComboBox;

            string url = $"https://{tscbFavorieten!.SelectedItem}";

            if (IsValidUri(url))
            {
                System.Uri uri = new Uri(url);
                webView1.Source = uri;
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
                Model.favorites.Add(strippedUrl);
                Model.Save();

                toolStripComboBoxFavorites.Items.Clear();
                SetFavoritesForBrowser();
            }
            else
            {
                MsgInvalidUrl();
            }
        }


        ////////////////////////////// Settings ///////////////////////////////////////////////////
        /// <summary>
        /// Toggle between webView1 and Settings.
        /// </summary>
        private void ToolStripButtonSettings_Click(object sender, EventArgs e)
        {
            if (webView1.Visible == false)
            {
                webView1.Visible = true;
                flowLayoutPanel1.Visible = false;
                toolStripButtonSettings.ToolTipText = "Settings";
            }
            else
            {
                webView1.Visible = false;
                flowLayoutPanel1.Visible = true;
                toolStripButtonSettings.ToolTipText = "Back to browser";
                flowLayoutPanel1.Controls.Clear();
                PopulateFlowLayoutPanelFavorites();
            }
        }

        /// <summary>
        /// Save edit favorites upon key Enter
        /// </summary>
        private void TextBoxFavorites_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using TextBox? tb = sender as TextBox;
                Model.favorites[(int)tb!.Tag!] = tb.Text.Trim();
                Model.Save();

                toolStripComboBoxFavorites.Items.Clear();
                SetFavoritesForBrowser();
                flowLayoutPanel1.Controls.Clear();
                PopulateFlowLayoutPanelFavorites();
            }
        }

        /// <summary>
        /// Save edit zoomfactor upon click and apply to webView1
        /// </summary>
        private void ButtonApplyZoomFactor_Click(object sender, EventArgs e)
        {
            webView1.ZoomFactor = (double)numericUpDown1.Value / 100;
            Model.zoomFactor = (double)numericUpDown1.Value;
            Model.Save();
            webView1.Reload();
        }

        /// <summary>
        /// Save edit appName upon click
        /// </summary>
        private void ButtonSetAppName_Click(object sender, EventArgs e)
        {
            this.Text = textBoxAppName.Text;
            Model.appName = textBoxAppName.Text;
            Model.Save();
        }

        /// <summary>
        /// Save edit startup Url
        /// </summary>
        private void comboBoxSetingsFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? cbFavorieten = sender as ComboBox;
            string url = $"https://{cbFavorieten!.SelectedItem}";

            if (IsValidUri(url))
            {
                System.Uri uri = new Uri(url);
                webView1.Source = uri;
                toolStripTextBoxUrl.Text = url;
                Model.startUpIndex = cbFavorieten.SelectedIndex;
                Model.Save();
            }
            else
            {
                MsgInvalidUrl();
            }
        }
    }
}
