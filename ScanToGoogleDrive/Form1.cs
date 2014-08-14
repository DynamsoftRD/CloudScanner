using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;

namespace ScanUpload
{
    public partial class ScanUploadToGoogle : Form
    {
        private string mFileTitle;
        private bool bToGoogle = false;
        private const string resxFile = @".\strings.resx";
        private ResXResourceSet resxSet;

        public ScanUploadToGoogle()
        {            
            resxSet = new ResXResourceSet(resxFile);

            InitializeComponent();

            this.Text = resxSet.GetString("app_title"); ;

            int lngNum;
            dynamicDotNetTwain.OpenSourceManager();
            for (lngNum = 0; lngNum < dynamicDotNetTwain.SourceCount; lngNum++)
            {     
               cmbSource.Items.Add(dynamicDotNetTwain.SourceNameItems(Convert.ToInt16(lngNum)));
            }
            if (lngNum > 0)
                cmbSource.SelectedIndex = 0;

            dynamicDotNetTwain.IfThrowException = true;

            IfInsertEnable();

            this.cmdUpload.Text = resxSet.GetString("button_upload");
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Hide();

            dynamicDotNetTwain.OnPostAllTransfers += dynamicDotNetTwain_OnPostAllTransfers;
        }

        void dynamicDotNetTwain_OnPostAllTransfers()
        {
            if (bToGoogle)
            {
                uploadToGoogleDrive();
                bToGoogle = false;
            }  
        }

        private void IfInsertEnable()
        {
            if (dynamicDotNetTwain.HowManyImagesInBuffer == 0)
            {
                cmdUpload.Enabled = true;
            }
            else
            {
                cmdUpload.Enabled = true;
            }
        }

        private void cmdScan_Click(object sender, EventArgs e)
        {
            dynamicDotNetTwain.IfAppendImage = false;
		    AcquireImage();
        }

        private bool isFileTitleExisted()
        {
            mFileTitle = this.textBox1.Text;
            if (mFileTitle.Equals(""))
            {
                MessageBox.Show(resxSet.GetString("msg_no_file_title"));
                return false;
            }

            return true;
        }

        private void uploadToGoogleDrive()
        {
            if (!isFileTitleExisted())
                return;

            if (dynamicDotNetTwain.CurrentImageIndexInBuffer == -1)
            {
                MessageBox.Show(resxSet.GetString("msg_no_image"));
                return;
            }

            this.progressBar1.Show();
            this.cmdUpload.Enabled = false;
            this.cmdScan.Enabled = false;
            this.scan_to_google.Enabled = false;
            this.backgroundWorker1.RunWorkerAsync(); // Run background task for uploading file
        }

        private void cmdUpload_Click(object sender, EventArgs e) 
        {
            uploadToGoogleDrive();
        }

        private void AcquireImage()
        {
            try
            {
                dynamicDotNetTwain.SelectSourceByIndex(Convert.ToInt16(cmbSource.SelectedIndex));
                dynamicDotNetTwain.IfShowUI = false;
                dynamicDotNetTwain.OpenSource();
                dynamicDotNetTwain.IfDisableSourceAfterAcquire = true;
                dynamicDotNetTwain.PixelType = Dynamsoft.DotNet.TWAIN.Enums.TWICapPixelType.TWPT_RGB;
                dynamicDotNetTwain.BitDepth = 24;
                dynamicDotNetTwain.Resolution = 300;
                dynamicDotNetTwain.AcquireImage();
            }
            catch (Dynamsoft.DotNet.TWAIN.TwainException exp)
            {
                String errorstr = "";
                errorstr += "Error " + exp.Code + "\r\n" + "Description: " + exp.Message + "\r\nPosition: " + exp.TargetSite + "\r\nHelp: " + exp.HelpLink + "\r\n";
                MessageBox.Show(errorstr);
            }
        }

        private void dynamicDotNetTwain_OnPreAllTransfers()
        {
            IfInsertEnable();
        }

        private void dynamicDotNetTwain_OnMouseClick(short sImageIndex)
        {
            dynamicDotNetTwain.CurrentImageIndexInBuffer = sImageIndex;
            IfInsertEnable();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Image image = dynamicDotNetTwain.GetImage(dynamicDotNetTwain.CurrentImageIndexInBuffer); // Get image data from memory
            string mimeType = "image/png";

            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "225130897923-o07dmhfk6o192e6tsnmeajk6g2njm3q2.apps.googleusercontent.com",
                    ClientSecret = "U17mnvBl3Xdbtwg8AyGM_C24",
                },
                new[] { DriveService.Scope.Drive },
                "user",
                CancellationToken.None).Result;

            // Create the service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "ScanUpload",
            });

            File body = new File();
            body.Title = mFileTitle;
            body.Description = "image";
            body.MimeType = mimeType;

            ImageConverter imageConverter = new ImageConverter();
            byte[] byteArray = (byte[])imageConverter.ConvertTo(image, typeof(byte[])); // convert image to byte
            System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

            FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, mimeType);
            MessageBox.Show(resxSet.GetString("msg_start_upload"));
            request.Upload();

            this.progressBar1.Hide();
            this.cmdUpload.Enabled = true;
            this.cmdScan.Enabled = true;
            this.scan_to_google.Enabled = true;
            MessageBox.Show(resxSet.GetString("msg_uploading_finished"));
        }

        private void scan_to_google_Click(object sender, EventArgs e)
        {
            bToGoogle = true;
            dynamicDotNetTwain.IfAppendImage = false;
            AcquireImage();
        }     
    }
}