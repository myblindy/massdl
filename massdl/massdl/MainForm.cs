using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using massdl.Properties;

namespace massdl
{
    public partial class MainForm : Form
    {
        private const string ImgurClientID = "dbd5b7b504210d8";
        private const string ImgurClientSecret = "8780bf86f25ce7a08997227d3a6bedec49324515";
        private readonly ImgurClient ImgurClient = new ImgurClient(ImgurClientID, ImgurClientSecret);

        public MainForm()
        {
            InitializeComponent();

            txtDownloadFolder.Text = Settings.Default.DownloadFolder;
            ClipboardNotification.ClipboardUpdate += ClipboardNotification_ClipboardUpdate;
        }

        private void Log(string msg) => lstLog.SelectedIndex = lstLog.Items.Add(msg);

        private async void ClipboardNotification_ClipboardUpdate(object sender, EventArgs e)
        {
            if (!chkListen.Checked) return;

            var text = Clipboard.GetText();
            var m = Regex.Match(text, @"imgur.com/a/([a-zA-Z0-9]+)$");
            if (m.Success)
            {
                // valid link, break it down
                Log("Downloading album " + text);
                var endpoint = new AlbumEndpoint(ImgurClient);
                var images = (await endpoint.GetAlbumImagesAsync(m.Groups[1].Value)).ToArray();
                int idx = 0;

                foreach (var image in images)
                {
                    var uri = new Uri(image.Link);
                    var dest = Path.Combine(txtDownloadFolder.Text, Path.GetFileName(uri.AbsolutePath));
                    await new WebClient().DownloadFileTaskAsync(uri, dest);
                    Log($"Downloaded {dest} ({++idx}/{images.Length})");
                }

                Log("Finished downloading album " + text);
            }
        }

        private void btnDownloadFolder_Click(object sender, EventArgs e)
        {
            using (var fldbrowser = new FolderBrowserDialog { SelectedPath = txtDownloadFolder.Text })
                if (fldbrowser.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.DownloadFolder = txtDownloadFolder.Text = fldbrowser.SelectedPath;
                    Settings.Default.Save();
                }
        }

        private void chkListen_CheckedChanged(object sender, EventArgs e) =>
            txtDownloadFolder.Enabled = btnDownloadFolder.Enabled = !chkListen.Checked;
    }
}
