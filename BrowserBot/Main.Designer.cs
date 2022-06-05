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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnStart = new MetroSet_UI.Controls.MetroSetButton();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tbxScripts = new System.Windows.Forms.TextBox();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lblLoadURL = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbxProfiles = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblProfiles = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSaveProfile = new MetroSet_UI.Controls.MetroSetButton();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            this.switchEnableDevTools = new MetroSet_UI.Controls.MetroSetSwitch();
            this.lblEnableDevTools = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
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
            this.btnStart.Location = new System.Drawing.Point(6, 892);
            this.btnStart.Name = "btnStart";
            this.btnStart.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStart.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStart.NormalTextColor = System.Drawing.Color.White;
            this.btnStart.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStart.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStart.PressTextColor = System.Drawing.Color.White;
            this.btnStart.Size = new System.Drawing.Size(206, 72);
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
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(6, 96);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(992, 284);
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
            this.cbxProfiles.Location = new System.Drawing.Point(665, 906);
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
            this.lblProfiles.Location = new System.Drawing.Point(556, 916);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(103, 26);
            this.lblProfiles.Style = MetroSet_UI.Enums.Style.Light;
            this.lblProfiles.StyleManager = null;
            this.lblProfiles.TabIndex = 7;
            this.lblProfiles.Text = "Profiles";
            this.lblProfiles.ThemeAuthor = "Narwin";
            this.lblProfiles.ThemeName = "MetroLite";
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveProfile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveProfile.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSaveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveProfile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveProfile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveProfile.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveProfile.IsDerivedStyle = true;
            this.btnSaveProfile.Location = new System.Drawing.Point(218, 892);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveProfile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveProfile.NormalTextColor = System.Drawing.Color.White;
            this.btnSaveProfile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveProfile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveProfile.PressTextColor = System.Drawing.Color.White;
            this.btnSaveProfile.Size = new System.Drawing.Size(206, 72);
            this.btnSaveProfile.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSaveProfile.StyleManager = null;
            this.btnSaveProfile.TabIndex = 8;
            this.btnSaveProfile.Text = "SAVE TO PROFILE";
            this.btnSaveProfile.ThemeAuthor = "Narwin";
            this.btnSaveProfile.ThemeName = "MetroLite";
            this.btnSaveProfile.Click += new System.EventHandler(this.BtnSaveProfile_Click);
            // 
            // loadingPicture
            // 
            this.loadingPicture.BackColor = System.Drawing.Color.Transparent;
            this.loadingPicture.Image = global::BrowserBot.Properties.Resources.boticon;
            this.loadingPicture.InitialImage = global::BrowserBot.Properties.Resources.boticon;
            this.loadingPicture.Location = new System.Drawing.Point(6, 96);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(992, 284);
            this.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingPicture.TabIndex = 9;
            this.loadingPicture.TabStop = false;
            // 
            // switchEnableDevTools
            // 
            this.switchEnableDevTools.BackColor = System.Drawing.Color.Transparent;
            this.switchEnableDevTools.BackgroundColor = System.Drawing.Color.Empty;
            this.switchEnableDevTools.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.switchEnableDevTools.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.switchEnableDevTools.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.switchEnableDevTools.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.switchEnableDevTools.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.switchEnableDevTools.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.switchEnableDevTools.IsDerivedStyle = true;
            this.switchEnableDevTools.Location = new System.Drawing.Point(15, 986);
            this.switchEnableDevTools.Name = "switchEnableDevTools";
            this.switchEnableDevTools.Size = new System.Drawing.Size(58, 22);
            this.switchEnableDevTools.Style = MetroSet_UI.Enums.Style.Light;
            this.switchEnableDevTools.StyleManager = null;
            this.switchEnableDevTools.Switched = false;
            this.switchEnableDevTools.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.switchEnableDevTools.TabIndex = 10;
            this.switchEnableDevTools.Text = "Enable Dev Tools";
            this.switchEnableDevTools.ThemeAuthor = "Narwin";
            this.switchEnableDevTools.ThemeName = "MetroLite";
            this.switchEnableDevTools.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // lblEnableDevTools
            // 
            this.lblEnableDevTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnableDevTools.IsDerivedStyle = true;
            this.lblEnableDevTools.Location = new System.Drawing.Point(89, 982);
            this.lblEnableDevTools.Name = "lblEnableDevTools";
            this.lblEnableDevTools.Size = new System.Drawing.Size(178, 26);
            this.lblEnableDevTools.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEnableDevTools.StyleManager = null;
            this.lblEnableDevTools.TabIndex = 11;
            this.lblEnableDevTools.Text = "Enable Dev Tools";
            this.lblEnableDevTools.ThemeAuthor = "Narwin";
            this.lblEnableDevTools.ThemeName = "MetroLite";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 1021);
            this.Controls.Add(this.lblEnableDevTools);
            this.Controls.Add(this.switchEnableDevTools);
            this.Controls.Add(this.loadingPicture);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.lblProfiles);
            this.Controls.Add(this.cbxProfiles);
            this.Controls.Add(this.lblLoadURL);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.tbxScripts);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "BrowserBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
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
        private MetroSet_UI.Controls.MetroSetButton btnSaveProfile;
        private PictureBox loadingPicture;
        private MetroSet_UI.Controls.MetroSetSwitch switchEnableDevTools;
        private MetroSet_UI.Controls.MetroSetLabel lblEnableDevTools;
    }
}