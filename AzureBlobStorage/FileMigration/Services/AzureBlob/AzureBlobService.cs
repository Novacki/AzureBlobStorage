using Azure.Storage.Blobs;
using FileMigration.Helpers.AzureBlob;
using FileMigration.Services.AzureBlob.Interfaces;

namespace FileMigration.Services.AzureBlob
{
    public class AzureBlobService : IAzureBlobService
    {
        private const string DIRECTORY_NAME = "Images";
        private readonly string _rootPath;

        public AzureBlobService()
        {
            _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        public void DownloadFiles(string containerName)
        {
            var containerClient = AzureBlobHelper.GetBlobContainerClientByContainerName(containerName);
            CreateDirectoryForFiles();

            var blobs = containerClient.GetBlobs();
            BlobClient blobClient;

            foreach(var blob in blobs)
            {
                blobClient = containerClient.GetBlobClient(blob.Name);
                blobClient.DownloadTo(GetPathToDownload(blob.Name));
            }   
        }

        private void CreateDirectoryForFiles()
        {
            if (Directory.Exists(GetImagePath()))
                return;
 
            Directory.CreateDirectory(GetImagePath());
        }

        private string GetPathToDownload(string imagePath)
        {
            var pathDownload = imagePath.Split("/");
            return Path.Combine(GetImagePath(), pathDownload.Last());
        }
            
        private string GetImagePath() =>
          Path.Combine(_rootPath, DIRECTORY_NAME);
    }
}
