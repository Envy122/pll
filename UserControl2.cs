using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace Project_Pluto
{
    public partial class UserControl2 : UserControl
    {
        private WebClient webClient;
        private string downloadUrl = "https://public.simplyblk.xyz/8.51.rar";
        private string downloadPath = @"C:\Path\To\Save\8.51.rar"; // Change this to your desired save path

        public UserControl2()
        {
            InitializeComponent();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://public.simplyblk.xyz/8.51.rar");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://public.simplyblk.xyz/8.51.rar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder containing 'Fortnite Game' and 'Engine' folders";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;

                    if (Directory.Exists(Path.Combine(selectedPath, "Fortnite Game")) &&
                        Directory.Exists(Path.Combine(selectedPath, "Engine")))

                    {

                    }
                    else
                    {
                        MessageBox.Show("Selected folder must contain both 'Fortnite Game' and 'Engine' folders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK) ;
            {

                folder.Description = "Select a folder containing 'Fortnite Game' and 'Engine' folders";

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folder.SelectedPath;

                    if (Directory.Exists(Path.Combine(selectedPath, "Fortnite Game")) &&
                        Directory.Exists(Path.Combine(selectedPath, "Engine"))) ;

                    {
                    }

                    {

                    }

                }
            }


        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder containing 'Fortnite Game' and 'Engine' folders";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Folder selected, enable the action button
                    
                }
;
                {
                    txtResult.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://public.simplyblk.xyz/8.51.rar");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/simplyblk/Fortnitebuilds");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_2(object sender, EventArgs e)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;

                try
                {
                    webClient.DownloadFileAsync(new Uri(downloadUrl), downloadPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Convert bytes to gigabytes for display
            double receivedGb = e.BytesReceived / 1024.0 / 1024.0 / 1024.0;
            double totalGb = e.TotalBytesToReceive / 1024.0 / 1024.0 / 1024.0;

           
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Download canceled.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("An error occurred: " + e.Error.Message);
            }
            else
            {
                MessageBox.Show("Download completed!");
            }
    }

        private void txtProgress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    string FortniteGamePath = Path.Combine(selectedFolder, "FortniteGame");
                    string EnginePath = Path.Combine(FortniteGamePath, "Engine");

                    if (Directory.Exists(FortniteGamePath) && Directory.Exists(EnginePath))
                    {
                        txtResult.Text = folderDialog.SelectedPath;
                    }
                }
                }
            }

        private void actionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Action performed!");
        }
    }
    }
    


               

            