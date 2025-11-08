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
            LoadFavorites();
            LoadFavoritesforSettingStartupUrl();

            // load startup website
            string s = "https://" + Properties.Settings.Default.favorites[Properties.Settings.Default.startUpIndex];
            webView21.Source = new Uri(s, UriKind.Absolute);

            webView21.ZoomFactor = Properties.Settings.Default.zoomfactor / 100;
            textBoxAppName.Text = Properties.Settings.Default.appName;
            this.Text = Properties.Settings.Default.appName;
        }

        /// <summary>
        /// Loads favorites into toolStripCombobox from Properties.Settings.Default.favorites
        /// </summary>
        private void LoadFavorites()
        {
            foreach (var item in Properties.Settings.Default.favorites)
            {
                toolStripComboBoxFavorites.Items.Add(item!);
            }
        }

        private void LoadFavoritesforSettingStartupUrl()
        {
            foreach (var item in Properties.Settings.Default.favorites)
            {
                comboBox1.Items.Add(item!);
            }
        }

        private static bool IsValidUri(string uriString)
        {
            bool result = Uri.TryCreate(uriString, UriKind.Absolute, out _);
            return result;
        }
        //
        // Form resize events
        //
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
        //
        // navigate to source after clicking magnifier button
        //
        private void ToolStripButtonGoTo_Click(object sender, EventArgs e)
        {
            if (IsValidUri(toolStripTextBoxUrl.Text))
            {
                System.Uri url = new Uri(toolStripTextBoxUrl.Text);
                webView21.Source = url;
            }
            else
            {
                MessageBox.Show(toolStripTextBoxUrl.Text + "is not a valid url", "Invalid");
            }
        }
        //
        // navigate to source after key enter
        //
        private void ToolStripTextBoxUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Object ob = new Object();
                EventArgs ee = new EventArgs();
                // we reuse an existing method 
                ToolStripButtonGoTo_Click(ob, ee);
            }
        }

        // De gekozen optie wordt voorzien van een https:// en die wordt als link aan webview21 gegeven
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
                MessageBox.Show(toolStripTextBoxUrl.Text + "is not a valid url", "Invalid");
            }
        }

        /// <summary>
        /// Content of toolStripTextBox1 is added to comboBoxFavorieten.
        /// </summary>
        private void ToolStripButtonAddToFav_Click(object sender, EventArgs e)
        {
            if (IsValidUri(toolStripTextBoxUrl.Text))
            {
                string strippedUrl = toolStripTextBoxUrl.Text.Substring(8);
                Properties.Settings.Default.favorites.Add(strippedUrl);
                Properties.Settings.Default.Save();

                toolStripComboBoxFavorites.Items.Clear();

                LoadFavorites();
            }
            else
            {
                MessageBox.Show(toolStripTextBoxUrl.Text + "is not a valid url", "Invalid");
            }
        }

        /// <summary>
        /// Changes the url in the toolStripTextBox if webView21 changes its source.
        /// </summary>
        private void WebView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            toolStripTextBoxUrl.Text = webView21.Source.ToString();
        }

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
                PopulatePanelOverviewFavorites();
            }
        }

        private void TextBoxFavorites_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (TextBox? tb = sender as TextBox)
                {
                    Properties.Settings.Default.favorites[(int)tb!.Tag!] = tb.Text.Trim();
                    Properties.Settings.Default.Save();

                    toolStripComboBoxFavorites.Items.Clear();
                    LoadFavorites();
                    flowLayoutPanel1.Controls.Clear();
                    PopulatePanelOverviewFavorites();
                }
            }
        }

        private void PopulatePanelOverviewFavorites()
        {
            int y = 5; int n = 0;
            foreach (var item in Properties.Settings.Default.favorites)
            {
                TextBox t = new TextBox();
                //t.Anchor = Anchor = AnchorStyles.Left | AnchorStyles.Right;
                t.Tag = n;
                t.KeyUp += TextBoxFavorites_KeyUp!;
                t.AppendText("  " + item);
                t.Width = 440;
                //t.Location = new Point(5, y);
                flowLayoutPanel1.Controls.Add(t);
                y = y + 26; n++;
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? cbFavorieten = sender as ComboBox;
            string url = $"https://{cbFavorieten!.SelectedItem}";
            
            if (IsValidUri(url))
            {
                System.Uri uurl = new Uri(url);
                webView21.Source = uurl;
                toolStripTextBoxUrl.Text = url;
                Properties.Settings.Default.startUpIndex = cbFavorieten.SelectedIndex;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show(toolStripTextBoxUrl.Text + "is not a valid url", "Invalid");
            }
        }



        //private void LeesXML()
        //{
        //    // dir lezen en filenamen in 
        //    // haalt de padnaam op waar het xml bestand staat

        //    Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        //    String path = Directory.GetCurrentDirectory();
        //    Root = XElement.Load(path + "\\Catch.xml");

        //    var records = Root.Elements();

        //    foreach (var record in records)
        //    {
        //        string name = (string)record.FirstAttribute;

        //        Record rec = new Record();
        //        rec.Name = name;
        //        Franz.Add(rec);

        //        menucomboBox1.Items.Add(rec.Name);

        //        ToolStripMenuItem tsmiDelete = new ToolStripMenuItem(rec.Name);
        //        tsmiDeleteRecord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiDelete });
        //        tsmiDelete.Click += new System.EventHandler(menuDelete_Click);

        //        foreach (var entr in record.Elements())
        //        {
        //            string styl = (string)entr.FirstAttribute;
        //            Veld ent = new Veld();
        //            ent.Entry = entr.Value;

        //            string substring = ent.Entry;
        //            FormatKeyStyleDictionary(substring);

        //            if (!styleDictionary.ContainsKey(rec.Name + substring))
        //            {
        //                styleDictionary.Add(rec.Name + substring, styl);
        //                //EntryLengthDictionary.Add(rec.Name + substring, ent.Entry.Length);
        //            }

        //            rec.RecordList.Add(ent);
        //        }
        //    }

        //    Record rl = new Record();
        //    rl.RecordList = Franz.FirstOrDefault().RecordList;

        //    Source = new BindingSource(rl.RecordList, null);

        //    if (menucomboBox1.Items.Count != 0)
        //    {
        //        menucomboBox1.SelectedItem = menucomboBox1.Items[0];
        //    }
        //}

        //private void SchrijfML()
        //{
        //    IEnumerable<XElement> LoopFranz()
        //    {
        //        foreach (var item in Franz)
        //        {
        //            XElement rec = new XElement("record");
        //            XAttribute name = new XAttribute("name", item.Name);
        //            rec.Add(name);

        //            foreach (var f in item.RecordList)
        //            {
        //                XElement entry = new XElement("entry", f.Entry);

        //                string substring = f.Entry;
        //                FormatKeyStyleDictionary(substring);

        //                string s = styleDictionary[item.Name + substring];
        //                XAttribute style = new XAttribute("style", s);
        //                entry.Add(style);
        //                rec.Add(entry);
        //            }
        //            yield return rec;
        //        }
        //    }
        //    XElement doc = new XElement("root", LoopFranz());

        //    Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        //    String path = Directory.GetCurrentDirectory();
        //    Root = XElement.Load(path + "\\Catch.xml");
        //    //Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        //    //String path = Directory.GetCurrentDirectory();

        //    //doc.Save(@"C:\Users\j.vannuijs\Desktop\XMLFile1.xml");
        //    doc.Save(path + "\\Catch.xml");

        //}

    }
}
