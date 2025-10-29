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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            textBox1 = new TextBox();
            buttonGo = new Button();
            comboBoxFavorieten = new ComboBox();
            buttonSuggesties = new Button();
            buttonSettings = new Button();
            buttonAdd = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(4, 52);
            webView21.Name = "webView21";
            webView21.Size = new Size(940, 583);
            webView21.Source = new Uri("https://www.concertzender.nl/themakanalen/", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(332, 11);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(42, 22);
            buttonGo.TabIndex = 2;
            buttonGo.Text = "Go";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // comboBoxFavorieten
            // 
            comboBoxFavorieten.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFavorieten.FormattingEnabled = true;
            comboBoxFavorieten.Items.AddRange(new object[] { "www.classicalwcrb.org/", "www.npoklassiek.nl/online-radio-luisteren/gedraaid", "www.vrt.be/vrtmax/livestream/audio/klaracontinuo/", "www.bbc.co.uk/sounds/play/live/bbc_radio_three", "www.concertzender.nl/themakanalen/", "google.com" });
            comboBoxFavorieten.Location = new Point(431, 10);
            comboBoxFavorieten.Name = "comboBoxFavorieten";
            comboBoxFavorieten.Size = new Size(268, 23);
            comboBoxFavorieten.TabIndex = 3;
            comboBoxFavorieten.SelectedIndexChanged += comboBoxFavorieten_SelectedIndexChanged;
            // 
            // buttonSuggesties
            // 
            buttonSuggesties.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSuggesties.Location = new Point(853, 10);
            buttonSuggesties.Name = "buttonSuggesties";
            buttonSuggesties.Size = new Size(75, 23);
            buttonSuggesties.TabIndex = 4;
            buttonSuggesties.Text = "Suggesties";
            buttonSuggesties.UseVisualStyleBackColor = true;
            buttonSuggesties.Click += buttonSuggesties_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSettings.Image = Properties.Resources.gear;
            buttonSettings.Location = new Point(808, 10);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(39, 23);
            buttonSettings.TabIndex = 5;
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(380, 10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(42, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(buttonGo);
            panel1.Controls.Add(buttonSettings);
            panel1.Controls.Add(comboBoxFavorieten);
            panel1.Controls.Add(buttonSuggesties);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 43);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(947, 638);
            Controls.Add(panel1);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(3);
            Text = "Klassieke Muziek Browser";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox textBox1;
        private Button buttonGo;
        private ComboBox comboBoxFavorieten;
        private Button buttonSuggesties;
        private Button buttonSettings;
        private Button buttonAdd;
        private Panel panel1;
    }
}
