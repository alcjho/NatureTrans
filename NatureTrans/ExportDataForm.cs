using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;

namespace NatureTrans
{
    public partial class ExportDataForm : Form
    {
        public ExportDataForm()
        {
            InitializeComponent();
        }

        private async Task UploadDatabaseToGoogleDrive(string filePath, string folderId)
        {
            // Authenticate using service account key
            GoogleCredential credential = GoogleCredential.FromFile("path/to/your/service_account_key.json");
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Your Application Name"
            });

            // Create file metadata
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(filePath),
                Parents = new[] { folderId } // Specify the folder ID if needed
            };

            // Open the file stream and create an upload request
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                FilesResource.CreateMediaUpload request = service.Files.Create(fileMetadata, fileStream, "application/octet-stream");
                request.Fields = "id";

                // Execute the upload and track progress
                IUploadProgress progress = null;
                do
                {
                    progress = await request.UploadAsync();
                    if (progress.Status == UploadStatus.Uploading)
                    {
                        double percentage = (double)progress.BytesSent / fileStream.Length * 100;
                        Console.WriteLine("Upload Progress: " + Math.Round(percentage, 2) + "%");
                    }
                }
                while (progress.Status == UploadStatus.Uploading);

                // Handle the upload result
                if (progress.Status == UploadStatus.Completed)
                {
                    Console.WriteLine("Upload complete.");
                    var file = request.ResponseBody;
                    Console.WriteLine("File ID: " + file.Id);
                }
                else
                {
                    Console.WriteLine("Upload failed: " + progress.Exception);
                }
            }
        }

        private void start_upload_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
