using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;

namespace WindowsMediaCreator
{
    public partial class DownloadForm : Form
    {
        private HttpDownloader httpDownloader = null;
        public string url;
        string youtubeLink;
        string xOthLink;
        string linktree;
        string instagram;
        string webSite;
        string tiktok = "https://tiktok.com/@tomex56";
        string discord = "https://discord.gg/hzC9t5bzNm"; //for winteros
        string patreon = "https://www.patreon.com/ntdev"; //for ntdev

        public string by;
        public void show(MainForm main)
        {
            if (btnPause.Text == GetResourceString("Home"))
            { main.Show(); this.Close(); }
        }

        public DownloadForm(string uri, MainForm main, string lang,string dev)
        {
            InitializeComponent();

            by = dev;
            SetLanguage(lang);
            RefreshUI();

            uri = uri.Replace("%20", " ");

            saveFileDialog1.FileName = Path.GetFileName(uri);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog1.FileName;
                httpDownloader = new HttpDownloader(uri, ruta);
                httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
                lblDownload.Text = GetResourceString("downPatch") + ruta;
                httpDownloader.Start();
            }
            else
            {
                btnPause.Text = GetResourceString("Home");
                show(main);
                return;
            }
        }

        //GetResourceString("operatingS")
        private void RefreshUI()
        {
            btnCancel.Text = GetResourceString("btnCancel2");
            saveFileDialog1.Title = GetResourceString("saveFile");
            saveFileDialog1.Filter = GetResourceString("filter");
            lblDownSpeed.Text = GetResourceString("lblDownSpeed");
            lblDown.Text = GetResourceString("lblDown");
            Text = GetResourceString("downloaderTitle");
            if (Properties.Settings.Default.lang == "en")
                grbDevInfo.Text = by + GetResourceString("devInformation");
            else
                grbDevInfo.Text = GetResourceString("devInformation") + by;
        }

        private string GetResourceString(string name)
        {
            return Properties.Resources.ResourceManager.GetString(name);
        }

        private void SetLanguage(string languageCode)
        {
            // Establecer la cultura global de la aplicación
            CultureInfo cultureInfo = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            lblProgreso.Text = $"{e.Progress.ToString("0.00")}%" + GetResourceString("complete");
            lblVelocidad.Text = string.Format("{0} MB/s",(e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lblDescargado.Text = string.Format("{0} MB", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            Text = "Windows Media Creator : " + lblProgreso.Text;
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblProgreso.Text = "100 %";
                btnPause.Text = GetResourceString("Home");
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetResourceString("msgTitleDownload") +
                Environment.NewLine +
                Environment.NewLine +
                GetResourceString("msgTitleDownload2"), "WMC", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == "WMC")
                    {
                        proceso.Kill();
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (httpDownloader.State == Status.Paused)
            { httpDownloader.Resume(); btnPause.Text = GetResourceString("btnPause"); }
            else
            { httpDownloader.Pause(); btnPause.Text = GetResourceString("Resumen"); }
            
        }

        private void DownloadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(GetResourceString("msgTitleDownload") +
                Environment.NewLine +
                Environment.NewLine +
                GetResourceString("msgTitleDownload2"), "WMC", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == "WMC")
                    {
                        proceso.Kill();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void lblName_TextChanged(object sender, EventArgs e)
        {
            if (lblName.Text == "WinterOS")
            {
                picLogo.Image = Properties.Resources.winteros;
                youtubeLink = "https://www.youtube.com/@WinterOS";
                linktree = "https://linktr.ee/winteros";
                panelx.Visible = false;
                panelPatreon.Visible = false;
                panelInstagram.Visible = false;
                panelTikTok.Visible = false;
                panel1.Visible = false;
            }
            else if (lblName.Text == "MiniOS 11" || lblName.Text == "MiniOS 10")
            {
                picLogo.Image = Properties.Resources.miniOS;
                youtubeLink = "https://www.youtube.com/@xdoofy92";
                xOthLink = "https://x.com/xdoofy92/";
                linktree = "https://linktr.ee/xdoofy92";
                instagram = "https://instagram.com/xdoofy92";
                panelDiscord.Visible = false;
                panelTikTok.Visible = false;
                webSite = "https://www.dprojects.org/minios";
            }
            else if (lblName.Text == "ShowOS Pro")
            {
                picLogo.Image = Properties.Resources.sfdx;
                youtubeLink = "https://www.youtube.com/@sfdxshow";
                xOthLink = "https://x.com/sfdxpro";
                panelDiscord.Visible = false;
                panelLink.Visible = false;
                panelPatreon.Visible = false;
                panelInstagram.Visible = false;
                panelTikTok.Visible = false;
                panel1.Visible = false;
            }
            else if (lblName.Text == "Tiny 11" || lblName.Text == "Tiny 10" || lblName.Text == "Tiny 12")
            {
                picLogo.Image = Properties.Resources.ntdev;
                youtubeLink = "https://www.youtube.com/@NTDEV";
                xOthLink = "https://x.com/NTDEV_";
                panelDiscord.Visible = false;
                panelLink.Visible = false;
                panelInstagram.Visible = false;
                panelTikTok.Visible = false;
                panel1.Visible = false;
            }
            else if (lblName.Text == "TomexOS")
            {
                picLogo.Image = Properties.Resources.tomex;
                youtubeLink = "https://www.youtube.com/@Tomex.";
                instagram = "https://instagram.com/eltomex";
                panelx.Visible = false;
                panelPatreon.Visible = false;
                panelDiscord.Visible = false;
                panelLink.Visible = false;
                panel1.Visible = false;
            }
            else if (lblName.Text == "WX-Lite")
            {
                lblName.Text = "Windows X-Lite";
                picLogo.Image = Properties.Resources.xlite;
                youtubeLink = "https://www.youtube.com/@WindowsX-Lite";
                webSite = "https://windowsxlite.com";
                panelInstagram.Visible = false;
                panelTikTok.Visible = false;
                panelx.Visible = false;
                panelPatreon.Visible = false;
                panelDiscord.Visible = false;
                panelLink.Visible = false;
            }
        }

        private void linkYoutube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(youtubeLink);
        }

        private void linkTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(xOthLink);
        }

        private void linkTree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linktree);
        }

        private void linkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(discord);
        }

        private void linkPatreon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(patreon);
        }

        private void linkInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(instagram);
        }

        private void linkTikTok_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(tiktok);
        }

        private void linkWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(webSite);
        }
    }
}
