using CefSharp;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace BrowserBot
{
    public partial class Main : MetroSet_UI.Forms.MetroSetForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private string SaveProfilesPath = "BrowserBot_Profiles";

        private void Form1_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadingStateChanged += ChromiumWebBrowser1_LoadingStateChanged;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (!Directory.Exists(SaveProfilesPath))
            {
                Directory.CreateDirectory(SaveProfilesPath);
            }
            /*Profile p = new() { Name = "DEMO1", ScriptContents = @"
                const linkUrl = $('#link').attr('href');
                function copyToClipBoard() {
                    var textArea = document.createElement('textarea');
                  textArea.value = linkUrl;
  
                  // Avoid scrolling to bottom
                  textArea.style.top = '0';
                  textArea.style.left = '0';
                  textArea.style.position = 'fixed';

                  document.body.appendChild(textArea);
                  textArea.focus();
                  textArea.select();

                  try {
                    var successful = document.execCommand('copy');
                    var msg = successful ? 'successful' : 'unsuccessful';
                    console.log('Fallback: Copying text command was ' + msg);
                  } catch (err) {
                    console.error('Fallback: Oops, unable to copy', err);
                  }

                  document.body.removeChild(textArea);
                    alert('Script Loaded');
                }
                copyToClipBoard();
            ", Url = "https://grantorrent.co/torrent/oal5k9wkoy/" };
            File.WriteAllText(Path.Combine(SaveProfilesPath, "ProfileDemo1.json"), JsonConvert.SerializeObject(p));
            */
            foreach(string Path in Directory.GetFiles(SaveProfilesPath, "*.json"))
            {
                Profile pTemp = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(Path));
                cbxProfiles.Items.Add(pTemp.Name);
            }
        }

        private void ChromiumWebBrowser1_LoadingStateChanged(object? sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                chromiumWebBrowser1.EvaluateScriptAsync(tbxScripts.Text);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl(tbxUrl.Text);
            loadingPicture.Visible = false;
            if (switchEnableDevTools.CheckState == MetroSet_UI.Enums.CheckState.Checked)
            {
                chromiumWebBrowser1.ShowDevTools();
            }
        }

        private void CbxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string Path in Directory.GetFiles(SaveProfilesPath, "*.json"))
            {
                Profile pTemp = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(Path));
                MetroSet_UI.Controls.MetroSetComboBox senderCbx = sender as MetroSet_UI.Controls.MetroSetComboBox;
                if (pTemp.Name == (senderCbx.SelectedItem.ToString()))
                {
                    tbxUrl.Text = pTemp.Url;
                    tbxScripts.Text = pTemp.ScriptContents;
                }
            }
        }

        private void BtnSaveProfile_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Input the name of the Profile", "Save Profile", "Profile-"+DateTime.Now.Ticks.ToString());
            Profile p = new() { Name = name, ScriptContents = tbxScripts.Text, Url = tbxUrl.Text };
            File.WriteAllText(Path.Combine(SaveProfilesPath, $"Profile_{Name}.json"), JsonConvert.SerializeObject(p));
        }
    }
}