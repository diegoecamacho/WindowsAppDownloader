using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;

namespace WindowsDownloadApp
{
    public partial class WindowAppDownloader : Form
    {

        bool Active = false;

        WebClient webClient = new WebClient();

        string DefaultPathLocation;

        Stack<DownloadLinkEnum> downloadApps= new Stack<DownloadLinkEnum>();

        DownloadLinkEnum currentDownload = DownloadLinkEnum.Default;

        public WindowAppDownloader()
        {
            InitializeComponent();
            webClient.DownloadFileCompleted += FileDownloadComplete;
            webClient.DownloadProgressChanged += FileDownloadProgress;
        }

        private void DownloadFile(DownloadLinkEnum downloadEnum)
        {
            Uri url = new Uri(GetEnumDescription(downloadEnum));

            var downloadpath = FilePathBox.Text = DefaultPathLocation + "\\" + GetFilenameFromWebServer(downloadEnum);

            webClient.DownloadFileAsync(url, downloadpath);

            currentDownload = downloadEnum;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
           if (!Active)
           {
               Active = true;
               foreach (var control in Controls)
               {
                   if (control is DownloadCheckbox)
                   {
                       var checkbox = (DownloadCheckbox)control;
                       if (checkbox.Checked && checkbox.DownloadType != DownloadLinkEnum.Default)
                       {
                            downloadApps.Push(checkbox.DownloadType);
                        }

                    }
               } 
               DownloadFile(downloadApps.Pop());
           }
        }

        public string GetFilenameFromWebServer(DownloadLinkEnum downloadEnum)
        {
           
            try
            {
                var request = WebRequest.Create(GetEnumDescription(downloadEnum));
                var response = request.GetResponse();
                var contentDisposition = response.Headers["Content-Disposition"];
                const string contentFileNamePortion = "filename=";
                var fileNameStartIndex = contentDisposition.IndexOf(contentFileNamePortion, StringComparison.InvariantCulture) + contentFileNamePortion.Length;

                var originalFileNameLength = contentDisposition.Length - fileNameStartIndex;
                var originalFileName = contentDisposition.Substring(fileNameStartIndex, originalFileNameLength);

                char[] trims = { '"' };
                var insert_ = originalFileName.Replace(" ", "_");

                var removefront = insert_.TrimStart(trims);

                originalFileName = removefront.TrimEnd(trims);

                return originalFileName;

            }
            catch (NullReferenceException)
            {
                 return downloadEnum.ToString() + ".exe";
            }
            catch(WebException)
            {
                return downloadEnum.ToString();
            }

           
        }


        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                DownloadUpdate.Text = "The download has been canceled";
 
            }
            else if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                DownloadUpdate.Text = "An error occurred while trying to download file";
            }
            else
            {
                DownloadUpdate.Text = currentDownload.ToString() +" Download Complete";
            }

            Thread.Sleep(500);

            if (downloadApps.Count == 0)
            {
                DownloadUpdate.Text = "All Download Completed";
                Active = false;
                return;
            }
            else
            {
                DownloadFile(downloadApps.Pop());
            }
        }

        private void FileDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadUpdate.Text = currentDownload.ToString() + " Download  Progress:" + e.ProgressPercentage;
        }

        string GetEnumDescription(DownloadLinkEnum enumValue)
        {
            var type = typeof(DownloadLinkEnum);
            var memInfo = type.GetMember(enumValue.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return ((DescriptionAttribute)attributes[0]).Description;

        }


        private void Browse_Click(object sender, EventArgs e)
        {
            var folderInstance = new FolderBrowserDialog();

            if (folderInstance.ShowDialog() == DialogResult.OK)
            {
               DefaultPathLocation = FilePathBox.Text = folderInstance.SelectedPath;
            }
        }

        private void downloadCheckbox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
