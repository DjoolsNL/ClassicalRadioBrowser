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
            toolStripTextBoxUrl = new ToolStripTextBox();
            toolStripButtonGoTo = new ToolStripButton();
            toolStripButtonAddToFav = new ToolStripButton();
            toolStripComboBoxFavorites = new ToolStripComboBox();
            toolStripButtonSettings = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            panelOverviewFavorites = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            buttonSetAppName = new Button();
            textBox1 = new TextBox();
            buttonApplyZoomFactor = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(4, 58);
            webView21.Name = "webView21";
            webView21.Size = new Size(513, 609);
            webView21.Source = new Uri("https://www.concertzender.nl/themakanalen/", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 0.5D;
            webView21.SourceChanged += WebView21_SourceChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBoxUrl, toolStripButtonGoTo, toolStripButtonAddToFav, toolStripComboBoxFavorites, toolStripButtonSettings });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(514, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxUrl
            // 
            toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            toolStripTextBoxUrl.Size = new Size(300, 25);
            toolStripTextBoxUrl.ToolTipText = "Enter a valid url";
            toolStripTextBoxUrl.KeyUp += ToolStripTextBoxUrl_KeyUp;
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
            toolStripButtonGoTo.Click += ToolStripButtonGoTo_Click;
            // 
            // toolStripButtonAddToFav
            // 
            toolStripButtonAddToFav.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddToFav.Image = Properties.Resources.star;
            toolStripButtonAddToFav.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddToFav.Name = "toolStripButtonAddToFav";
            toolStripButtonAddToFav.Size = new Size(23, 22);
            toolStripButtonAddToFav.Text = "toolStripButton2";
            toolStripButtonAddToFav.ToolTipText = "Add url to Favorites";
            toolStripButtonAddToFav.Click += ToolStripButtonAddToFav_Click;
            // 
            // toolStripComboBoxFavorites
            // 
            toolStripComboBoxFavorites.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxFavorites.DropDownWidth = 300;
            toolStripComboBoxFavorites.FlatStyle = FlatStyle.System;
            toolStripComboBoxFavorites.Name = "toolStripComboBoxFavorites";
            toolStripComboBoxFavorites.Size = new Size(120, 25);
            toolStripComboBoxFavorites.ToolTipText = "Favorites";
            toolStripComboBoxFavorites.SelectedIndexChanged += ToolStripComboBoxFavorites_SelectedIndexChanged;
            // 
            // toolStripButtonSettings
            // 
            toolStripButtonSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSettings.Image = Properties.Resources.gear1;
            toolStripButtonSettings.ImageTransparentColor = Color.Magenta;
            toolStripButtonSettings.Name = "toolStripButtonSettings";
            toolStripButtonSettings.Size = new Size(23, 22);
            toolStripButtonSettings.Text = "Settings";
            toolStripButtonSettings.Click += ToolStripButtonSettings_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panelOverviewFavorites);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonSetAppName);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(buttonApplyZoomFactor);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(4, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 609);
            panel1.TabIndex = 9;
            // 
            // panelOverviewFavorites
            // 
            panelOverviewFavorites.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOverviewFavorites.AutoScroll = true;
            panelOverviewFavorites.BorderStyle = BorderStyle.FixedSingle;
            panelOverviewFavorites.Location = new Point(17, 170);
            panelOverviewFavorites.Margin = new Padding(5);
            panelOverviewFavorites.Name = "panelOverviewFavorites";
            panelOverviewFavorites.Padding = new Padding(3);
            panelOverviewFavorites.Size = new Size(478, 412);
            panelOverviewFavorites.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 53);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 10;
            label1.Text = "(fullscreen: 100, small: 50)";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 40);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 3;
            label2.Text = "Settings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 136);
            label3.Name = "label3";
            label3.Size = new Size(403, 15);
            label3.TabIndex = 8;
            label3.Text = "Favorites - Add and delete entries - Pressing the enter key will save our edit.";
            // 
            // buttonSetAppName
            // 
            buttonSetAppName.Location = new Point(24, 87);
            buttonSetAppName.Name = "buttonSetAppName";
            buttonSetAppName.Size = new Size(105, 23);
            buttonSetAppName.TabIndex = 6;
            buttonSetAppName.Text = "Name";
            buttonSetAppName.UseVisualStyleBackColor = true;
            buttonSetAppName.Click += ButtonSetAppName_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 23);
            textBox1.TabIndex = 4;
            // 
            // buttonApplyZoomFactor
            // 
            buttonApplyZoomFactor.Location = new Point(24, 49);
            buttonApplyZoomFactor.Name = "buttonApplyZoomFactor";
            buttonApplyZoomFactor.Size = new Size(105, 23);
            buttonApplyZoomFactor.TabIndex = 2;
            buttonApplyZoomFactor.Text = "Set zoomfactor";
            buttonApplyZoomFactor.UseVisualStyleBackColor = true;
            buttonApplyZoomFactor.Click += ButtonApplyZoomFactor_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(135, 51);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SeaShell;
            ClientSize = new Size(520, 670);
            Controls.Add(toolStrip1);
            Controls.Add(webView21);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(3);
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
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
        private Label label2;
        private TextBox textBox1;
        private Button buttonSetAppName;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Panel panelOverviewFavorites;
    }
}
