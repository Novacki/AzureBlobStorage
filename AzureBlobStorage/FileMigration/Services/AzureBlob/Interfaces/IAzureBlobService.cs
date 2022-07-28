using FileMigration.Models.AzureBlob;

namespace FileMigration.Services.AzureBlob.Interfaces
{
    public interface IAzureBlobService
    {
        void DownloadFiles(string containerName);
    }
}
