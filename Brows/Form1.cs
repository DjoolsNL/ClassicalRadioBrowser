using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace Brows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //numericUpDown1.Value = (decimal)Properties.Settings.Default.zoomfactor;
            webView21.ZoomFactor = Properties.Settings.Default.zoomfactor / 100;
            textBox1.Text = Properties.Settings.Default.appName;
            this.Text = Properties.Settings.Default.appName;
        }

        private static bool IsValidUri(string uriString)
        {
            bool result = Uri.TryCreate(uriString, UriKind.Absolute, out Uri uriResult);
            return result;
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
            System.Uri uri = new Uri(url);
            webView21.Source = uri;
            toolStripTextBoxUrl.Text = url;
            this.Focus();
        }

        /// <summary>
        /// Content of toolStripTextBox1 is added to comboBoxFavorieten.
        /// </summary>
        private void toolStripButtonAddToFav_Click(object sender, EventArgs e)
        {
            if (IsValidUri(toolStripTextBoxUrl.Text))
            {
                string strippedUrl = toolStripTextBoxUrl.Text.Substring(8);
                toolStripComboBoxFavorites.Items.Add(strippedUrl);
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
