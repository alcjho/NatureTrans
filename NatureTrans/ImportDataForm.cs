using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatureTrans
{
    public partial class ImportDataForm : Form
    {
        public ImportDataForm()
        {
            InitializeComponent();
        }

        private void ImportDataForm_Load(object sender, EventArgs e)
        {
            from_url_txt.Text = "http://";
        }
        private async Task ListFilesOnGoogleDrive()
        {
            UserCredential credential;
            using (var stream = new FileStream("C:\\NTSystems\\client_secret_964160827774-ooa1eejupoajbnbhnd7pgnbsqg59q3a3.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    new[] { DriveService.Scope.DriveFile },
                    "user", CancellationToken.None, new FileDataStore("Books.ListMyLibrary"));
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "NTSystems"
            });

            // Create a list request to get files
            FilesResource.ListRequest request = service.Files.List();
            request.Fields = "nextPageToken, files(id, name, mimeType)";  // Define the fields to retrieve
            request.PageSize = 10; // Limit to 10 results for demonstration; modify as needed
            //request.Q = "name = ntdb.zip";

            // Execute the request and display the files
            FileList result = await request.ExecuteAsync();
            IList<Google.Apis.Drive.v3.Data.File> files = result.Files;
            Console.WriteLine("Searching for files on Google drive");

            if (files != null && files.Count > 0)
            {
                Console.WriteLine("Files on Google Drive:");
                foreach (var file in files)
                {
                    Console.WriteLine($"File ID: {file.Id} - Name: {file.Name} - MIME Type: {file.MimeType}");
                }
            }
            else
            {
                Console.WriteLine("No files found.");
            }
        }

        private async Task DownloadFileFromGoogleDrive(string fileId, string destinationPath)
        {
            // Authenticate using the service account key
            GoogleCredential credential = GoogleCredential.FromFile("path/to/your/service_account_key.json");
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Your Application Name"
            });

            // Create a request to download the file
            var request = service.Files.Get(fileId);
            using (var memoryStream = new MemoryStream())
            {
                // Execute the download
                var progress = await request.DownloadAsync(memoryStream);

                if (progress.Status == Google.Apis.Download.DownloadStatus.Completed)
                {
                    // Save the downloaded content to the destination path
                    using (var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
                    {
                        memoryStream.WriteTo(fileStream);
                    }
                    Console.WriteLine("Download complete. File saved to: " + destinationPath);
                }
                else
                {
                    Console.WriteLine("Download failed: " + progress.Exception?.Message);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await ListFilesOnGoogleDrive();
        }
    }
}
