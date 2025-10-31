﻿namespace Brows
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
            toolStripTextBoxUrl = new ToolStripTextBox();
            toolStripButtonGoTo = new ToolStripButton();
            toolStripButtonAddToFav = new ToolStripButton();
            toolStripComboBoxFavorites = new ToolStripComboBox();
            toolStripButtonSettings = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            label2 = new Label();
            buttonApplyZoomFactor = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            webView21.ZoomFactor = 5D;
            webView21.SourceChanged += webView21_SourceChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBoxUrl, toolStripButtonGoTo, toolStripButtonAddToFav, toolStripComboBoxFavorites, toolStripButtonSettings });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(512, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxUrl
            // 
            toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            toolStripTextBoxUrl.Size = new Size(300, 25);
            toolStripTextBoxUrl.ToolTipText = "Enter a valid url";
            toolStripTextBoxUrl.KeyUp += toolStripTextBoxUrl_KeyUp;
            // 
            // toolStripButtonGoTo
            // 
            toolStripButtonGoTo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonGoTo.Image = Properties.Resources.magnifier_left;
            toolStripButtonGoTo.ImageTransparentColor = Color.Magenta;
            toolStripButtonGoTo.Name = "toolStripButtonGoTo";
            toolStripButtonGoTo.Size = new Size(23, 22);
            toolStripButtonGoTo.Text = "toolStripButton1";
            toolStripButtonGoTo.ToolTipText = "Go to url";
            toolStripButtonGoTo.Click += toolStripButtonGoTo_Click;
            // 
            // toolStripButtonAddToFav
            // 
            toolStripButtonAddToFav.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddToFav.Image = Properties.Resources.thumb_up;
            toolStripButtonAddToFav.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddToFav.Name = "toolStripButtonAddToFav";
            toolStripButtonAddToFav.Size = new Size(23, 22);
            toolStripButtonAddToFav.Text = "toolStripButton2";
            toolStripButtonAddToFav.ToolTipText = "Add url to Favorites";
            toolStripButtonAddToFav.Click += toolStripButtonAddToFav_Click;
            // 
            // toolStripComboBoxFavorites
            // 
            toolStripComboBoxFavorites.AutoCompleteCustomSource.AddRange(new string[] { "www.classicalwcrb.org/", "www.npoklassiek.nl/online-radio-luisteren/gedraaid", "www.vrt.be/vrtmax/livestream/audio/klaracontinuo/", "www.vrt.be/vrtmax/livestream/audio/klara/", "www.bbc.co.uk/sounds/play/live/bbc_radio_three", "www.concertzender.nl/themakanalen/", "google.com" });
            toolStripComboBoxFavorites.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxFavorites.DropDownWidth = 250;
            toolStripComboBoxFavorites.FlatStyle = FlatStyle.System;
            toolStripComboBoxFavorites.Items.AddRange(new object[] { "www.classicalwcrb.org/", "www.npoklassiek.nl/online-radio-luisteren/gedraaid", "www.vrt.be/vrtmax/livestream/audio/klaracontinuo/", "www.vrt.be/vrtmax/livestream/audio/klara/", "www.bbc.co.uk/sounds/play/live/bbc_radio_three", "www.concertzender.nl/themakanalen/", "google.com" });
            toolStripComboBoxFavorites.Name = "toolStripComboBoxFavorites";
            toolStripComboBoxFavorites.Size = new Size(121, 25);
            toolStripComboBoxFavorites.ToolTipText = "Favorites";
            toolStripComboBoxFavorites.SelectedIndexChanged += toolStripComboBoxFavorites_SelectedIndexChanged;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonApplyZoomFactor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(4, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 596);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 21);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 3;
            label2.Text = "Settings";
            // 
            // buttonApplyZoomFactor
            // 
            buttonApplyZoomFactor.Location = new Point(350, 72);
            buttonApplyZoomFactor.Name = "buttonApplyZoomFactor";
            buttonApplyZoomFactor.Size = new Size(52, 23);
            buttonApplyZoomFactor.TabIndex = 2;
            buttonApplyZoomFactor.Text = "Apply";
            buttonApplyZoomFactor.UseVisualStyleBackColor = true;
            buttonApplyZoomFactor.Click += buttonApplyZoomFactor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 73);
            label1.Name = "label1";
            label1.Size = new Size(257, 15);
            label1.TabIndex = 1;
            label1.Text = "Set zoomfactor browser (normal: 100, small: 50)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(296, 72);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(518, 638);
            Controls.Add(toolStrip1);
            Controls.Add(webView21);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(3);
            Text = "Klassieke Muziek Browser";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTextBoxUrl;
        private ToolStripButton toolStripButtonGoTo;
        private ToolStripComboBox toolStripComboBoxFavorites;
        private ToolStripButton toolStripButtonAddToFav;
        private ToolStripButton toolStripButtonSettings;
        private ToolTip toolTip1;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private Button buttonApplyZoomFactor;
        private Label label1;
        private Label label2;
    }
}
