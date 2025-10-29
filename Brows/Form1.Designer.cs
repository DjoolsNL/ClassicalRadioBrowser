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
            button3 = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(1, 47);
            webView21.Name = "webView21";
            webView21.Size = new Size(946, 591);
            webView21.Source = new Uri("https://www.buienradar.nl/nederland/neerslag/buienradar", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(333, 12);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(42, 23);
            buttonGo.TabIndex = 2;
            buttonGo.Text = "Go";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // comboBoxFavorieten
            // 
            comboBoxFavorieten.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFavorieten.FormattingEnabled = true;
            comboBoxFavorieten.Items.AddRange(new object[] { "www.classicalwcrb.org/", "www.npoklassiek.nl/online-radio-luisteren/gedraaid", "www.vrt.be/vrtmax/livestream/audio/klaracontinuo/", "www.bbc.co.uk/sounds/play/live/bbc_radio_three", "google.com" });
            comboBoxFavorieten.Location = new Point(432, 11);
            comboBoxFavorieten.Name = "comboBoxFavorieten";
            comboBoxFavorieten.Size = new Size(268, 23);
            comboBoxFavorieten.TabIndex = 3;
            comboBoxFavorieten.SelectedIndexChanged += comboBoxFavorieten_SelectedIndexChanged;
            // 
            // buttonSuggesties
            // 
            buttonSuggesties.Location = new Point(860, 9);
            buttonSuggesties.Name = "buttonSuggesties";
            buttonSuggesties.Size = new Size(75, 25);
            buttonSuggesties.TabIndex = 4;
            buttonSuggesties.Text = "Suggesties";
            buttonSuggesties.UseVisualStyleBackColor = true;
            buttonSuggesties.Click += buttonSuggesties_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(815, 9);
            button3.Name = "button3";
            button3.Size = new Size(39, 25);
            button3.TabIndex = 5;
            button3.Text = ". . .";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(381, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(42, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(947, 638);
            Controls.Add(buttonAdd);
            Controls.Add(button3);
            Controls.Add(buttonSuggesties);
            Controls.Add(comboBoxFavorieten);
            Controls.Add(buttonGo);
            Controls.Add(textBox1);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Jules on Edge";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox textBox1;
        private Button buttonGo;
        private ComboBox comboBoxFavorieten;
        private Button buttonSuggesties;
        private Button button3;
        private Button buttonAdd;
    }
}
