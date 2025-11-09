using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Brows
{
    partial class Form1
    {
        // ///////////////////////// Browser /////////////////////////////////////// 
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width > 536)
            {
                toolStripTextBoxUrl.Size = new Size(this.Size.Width / 100 * 55, 25);
                toolStripComboBoxFavorites.Size = new Size(this.Size.Width / 100 * 30, 25);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void SetFavoritesForBrowser()
        {
            foreach (var item in Model.favorites)
            {
                toolStripComboBoxFavorites.Items.Add(item!);
            }
        }

        private static bool IsValidUri(string uriString)
        {
            bool result = Uri.TryCreate(uriString, UriKind.Absolute, out _);
            return result;
        }

        private void MsgInvalidUrl()
        {
            MessageBox.Show(toolStripTextBoxUrl.Text + "is not a valid url", "Invalid");
        }

        /// <summary>
        /// Display current url in the toolStripTextBox
        /// </summary>
        private void webView1_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            toolStripTextBoxUrl.Text = webView1.Source.ToString();
        }


        // ////////////////////////// Settings ////////////////////////////////
        /// <summary>
        /// Custom App settings
        /// </summary>
        private void SetPopertiesSettingsDefault()
        {
            // load startup website
            string s = "https://" + Model.favorites[Model.startUpIndex];
            webView1.Source = new Uri(s, UriKind.Absolute);

            webView1.ZoomFactor = Model.zoomFactor / 100;
            textBoxAppName.Text = Model.appName;
            this.Text = Model.appName;
        }

        private void PopulateFlowLayoutPanelFavorites()
        {
            int n = 0;
            foreach (var item in Properties.Settings.Default.favorites)
            {
                TextBox t = new TextBox();
                t.Tag = n;
                t.KeyUp += TextBoxFavorites_KeyUp!;
                t.AppendText("  " + item);
                t.Width = 440;
                flowLayoutPanel1.Controls.Add(t);
                n++;
            }
        }

        private void SetFavoritesForSettings()
        {
            foreach (var item in Model.favorites)
            {
                comboBoxSetingsFavorites.Items.Add(item!);
            }
        }
    }
}
