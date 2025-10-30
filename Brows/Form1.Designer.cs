namespace Brows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1 = new ToolStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripButtonSettings = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(4, 39);
            webView21.Name = "webView21";
            webView21.Size = new Size(511, 596);
            webView21.Source = new Uri("https://www.concertzender.nl/themakanalen/", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 0.5D;
            webView21.SourceChanged += webView21_SourceChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripButton1, toolStripButton2, toolStripComboBox1, toolStripButtonSettings });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(512, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(300, 25);
            toolStripTextBox1.ToolTipText = "Enter a valid url";
            toolStripTextBox1.KeyUp += toolStripTextBox1_KeyUp;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.magnifier_left;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Go to url";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.thumb_up;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Add url to Favorites";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] { "www.classicalwcrb.org/", "www.npoklassiek.nl/online-radio-luisteren/gedraaid", "www.vrt.be/vrtmax/livestream/audio/klaracontinuo/", "www.vrt.be/vrtmax/livestream/audio/klara/", "www.bbc.co.uk/sounds/play/live/bbc_radio_three", "www.concertzender.nl/themakanalen/", "google.com" });
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "www.classicalwcrb.org/", "www.npoklassiek.nl/online-radio-luisteren/gedraaid", "www.vrt.be/vrtmax/livestream/audio/klaracontinuo/", "www.vrt.be/vrtmax/livestream/audio/klara/", "www.bbc.co.uk/sounds/play/live/bbc_radio_three", "www.concertzender.nl/themakanalen/", "google.com" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            toolStripComboBox1.ToolTipText = "Favorites";
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // toolStripButtonSettings
            // 
            toolStripButtonSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSettings.Image = Properties.Resources.gear1;
            toolStripButtonSettings.ImageTransparentColor = Color.Magenta;
            toolStripButtonSettings.Name = "toolStripButtonSettings";
            toolStripButtonSettings.Size = new Size(23, 20);
            toolStripButtonSettings.Text = "Settings";
            toolStripButtonSettings.Click += toolStripButtonSettings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(518, 638);
            Controls.Add(toolStrip1);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(3);
            Text = "Klassieke Muziek Browser";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButtonSettings;
        private ToolTip toolTip1;
    }
}
