namespace BrowserBot
{
    partial class Main
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
            this.btnStart = new MetroSet_UI.Controls.MetroSetButton();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tbxScripts = new System.Windows.Forms.TextBox();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lblLoadURL = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbxProfiles = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblProfiles = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStart.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStart.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStart.HoverTextColor = System.Drawing.Color.White;
            this.btnStart.IsDerivedStyle = true;
            this.btnStart.Location = new System.Drawing.Point(15, 892);
            this.btnStart.Name = "btnStart";
            this.btnStart.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStart.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStart.NormalTextColor = System.Drawing.Color.White;
            this.btnStart.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStart.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStart.PressTextColor = System.Drawing.Color.White;
            this.btnStart.Size = new System.Drawing.Size(388, 72);
            this.btnStart.Style = MetroSet_UI.Enums.Style.Light;
            this.btnStart.StyleManager = null;
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "LOAD";
            this.btnStart.ThemeAuthor = "Narwin";
            this.btnStart.ThemeName = "MetroLite";
            this.btnStart.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(1, 6);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(997, 374);
            this.chromiumWebBrowser1.TabIndex = 2;
            this.chromiumWebBrowser1.Text = "chromiumWebBrowser1";
            // 
            // tbxScripts
            // 
            this.tbxScripts.Location = new System.Drawing.Point(1, 442);
            this.tbxScripts.Multiline = true;
            this.tbxScripts.Name = "tbxScripts";
            this.tbxScripts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxScripts.Size = new System.Drawing.Size(997, 444);
            this.tbxScripts.TabIndex = 3;
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(110, 396);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(888, 37);
            this.tbxUrl.TabIndex = 4;
            // 
            // lblLoadURL
            // 
            this.lblLoadURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoadURL.IsDerivedStyle = true;
            this.lblLoadURL.Location = new System.Drawing.Point(1, 399);
            this.lblLoadURL.Name = "lblLoadURL";
            this.lblLoadURL.Size = new System.Drawing.Size(103, 34);
            this.lblLoadURL.Style = MetroSet_UI.Enums.Style.Light;
            this.lblLoadURL.StyleManager = null;
            this.lblLoadURL.TabIndex = 5;
            this.lblLoadURL.Text = "Load URL";
            this.lblLoadURL.ThemeAuthor = "Narwin";
            this.lblLoadURL.ThemeName = "MetroLite";
            // 
            // cbxProfiles
            // 
            this.cbxProfiles.AllowDrop = true;
            this.cbxProfiles.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxProfiles.BackColor = System.Drawing.Color.Transparent;
            this.cbxProfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbxProfiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxProfiles.CausesValidation = false;
            this.cbxProfiles.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxProfiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxProfiles.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxProfiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxProfiles.FormattingEnabled = true;
            this.cbxProfiles.IsDerivedStyle = true;
            this.cbxProfiles.ItemHeight = 40;
            this.cbxProfiles.Location = new System.Drawing.Point(669, 914);
            this.cbxProfiles.Name = "cbxProfiles";
            this.cbxProfiles.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxProfiles.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxProfiles.Size = new System.Drawing.Size(329, 46);
            this.cbxProfiles.Style = MetroSet_UI.Enums.Style.Light;
            this.cbxProfiles.StyleManager = null;
            this.cbxProfiles.TabIndex = 6;
            this.cbxProfiles.ThemeAuthor = "Narwin";
            this.cbxProfiles.ThemeName = "MetroLite";
            this.cbxProfiles.SelectedIndexChanged += new System.EventHandler(this.CbxProfiles_SelectedIndexChanged);
            // 
            // lblProfiles
            // 
            this.lblProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfiles.IsDerivedStyle = true;
            this.lblProfiles.Location = new System.Drawing.Point(560, 923);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(103, 26);
            this.lblProfiles.Style = MetroSet_UI.Enums.Style.Light;
            this.lblProfiles.StyleManager = null;
            this.lblProfiles.TabIndex = 7;
            this.lblProfiles.Text = "Profiles";
            this.lblProfiles.ThemeAuthor = "Narwin";
            this.lblProfiles.ThemeName = "MetroLite";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 975);
            this.Controls.Add(this.lblProfiles);
            this.Controls.Add(this.cbxProfiles);
            this.Controls.Add(this.lblLoadURL);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.tbxScripts);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.btnStart);
            this.Name = "Main";
            this.Text = "BrowserBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnStart;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private TextBox tbxScripts;
        private TextBox tbxUrl;
        private MetroSet_UI.Controls.MetroSetLabel lblLoadURL;
        private MetroSet_UI.Controls.MetroSetComboBox cbxProfiles;
        private MetroSet_UI.Controls.MetroSetLabel lblProfiles;
    }
}