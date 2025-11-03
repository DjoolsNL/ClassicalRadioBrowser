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
            reloadFavorites();
            //reloadFavoritessDatagridView();  
        }

        private void reloadFavorites()
        {
            foreach (var item in Properties.Settings.Default.favorites)
            {
                toolStripComboBoxFavorites.Items.Add(item);

            }
        }

        private void reloadFavoritessDatagridView()
        {
            foreach (var item in Properties.Settings.Default.favorites)
            {

            }
        }

        private static bool IsValidUri(string uriString)
        {
            bool result = Uri.TryCreate(uriString, UriKind.Absolute, out Uri uriResult);
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //numericUpDown1.Value = (decimal)Properties.Settings.Default.zoomfactor;
            webView21.ZoomFactor = Properties.Settings.Default.zoomfactor / 100;
            textBox1.Text = Properties.Settings.Default.appName;
            this.Text = Properties.Settings.Default.appName;
        }

        // navigate to source after clicking magnifier button
        private void toolStripButtonGoTo_Click(object sender, EventArgs e)
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

        // navigate to source after key enter
        private void toolStripTextBoxUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Object o = new Object();
                EventArgs ee = new EventArgs();
                toolStripButtonGoTo_Click(o, ee);
            }
        }

        // De gekozen optie wordt voorzien van een https:// en die wordt als link aan webview21 gegeven
        private void toolStripComboBoxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox? tscbFavorieten = sender as ToolStripComboBox;
            string url = $"https://{tscbFavorieten!.SelectedItem}";

            if (IsValidUri(url))
            {
                System.Uri uurl = new Uri(url);
                webView21.Source = uurl;
                toolStripTextBoxUrl.Text = url;
                this.Focus();
                toolStripComboBoxFavorites.Size = new System.Drawing.Size(35, 25);
            }
            else
            {
                MessageBox.Show(toolStripTextBoxUrl.Text + "is not a valid url", "Invalid");
            }
        }

        /// <summary>
        /// Content of toolStripTextBox1 is added to comboBoxFavorieten.
        /// </summary>
        private void toolStripButtonAddToFav_Click(object sender, EventArgs e)
        {
            if (IsValidUri(toolStripTextBoxUrl.Text))
            {
                string strippedUrl = toolStripTextBoxUrl.Text.Substring(8);
                Properties.Settings.Default.favorites.Add(strippedUrl);
                Properties.Settings.Default.Save();

                toolStripComboBoxFavorites.Items.Clear();

                reloadFavorites();
            }
            else
            {
                MessageBox.Show(toolStripTextBoxUrl.Text + "is not a valid url", "Invalid");
            }
        }

        /// <summary>
        /// Changes the url in the toolStripTextBox if webView21 changes its source.
        /// </summary>
        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            toolStripTextBoxUrl.Text = webView21.Source.ToString();
        }

        /// <summary>
        /// Toggle between webView21 and Settings.
        /// </summary>
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
                panel3.Controls.Clear();
                populatePanel3();
            }
        }

        private void textBoxFavorites_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (TextBox? tb = sender as TextBox)
                {
                    Properties.Settings.Default.favorites[(int)tb!.Tag!] = tb.Text;
                    Properties.Settings.Default.Save();

                    toolStripComboBoxFavorites.Items.Clear();
                    reloadFavorites();
                    panel3.Controls.Clear();
                    populatePanel3();
                }
            }
        }

        private void populatePanel3()
        {
            int y = 5; int n = 0;
            foreach (var item in Properties.Settings.Default.favorites)
            {
                TextBox t = new TextBox();
                t.Anchor = Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                t.Tag = n;
                t.KeyUp += textBoxFavorites_KeyUp!;
                t.AppendText(item);
                t.Width = 440;
                t.Location = new Point(5, y);
                panel3.Controls.Add(t);
                y = y + 26; n++;
            }
        }

        private void buttonApplyZoomFactor_Click(object sender, EventArgs e)
        {
            webView21.ZoomFactor = (double)numericUpDown1.Value / 100;
            Properties.Settings.Default.zoomfactor = (double)numericUpDown1.Value;
            Properties.Settings.Default.Save();
            webView21.Reload();
        }

        private void buttonSetAppName_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            Properties.Settings.Default.appName = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //if(this.Size
            //    }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Properties.Settings.Default.favorites.Add(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            Properties.Settings.Default.Save();

            toolStripComboBoxFavorites.Items.Clear();

            reloadFavorites();
        }

        private void toolStripComboBoxFavorites_Click(object sender, EventArgs e)
        {
            toolStripComboBoxFavorites.Size = new System.Drawing.Size(121, 25);
        }

        private void toolStripComboBoxFavorites_MouseEnter(object sender, EventArgs e)
        {
            toolStripComboBoxFavorites.Size = new System.Drawing.Size(121, 25);
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
