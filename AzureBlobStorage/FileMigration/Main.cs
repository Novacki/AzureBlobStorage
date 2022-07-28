using FileMigration.Models.AzureBlob;
using FileMigration.Services.AzureBlob;

namespace FileMigration
{
    public static class Main
    {
        public static void Start()
        {
            var service = new AzureBlobService();
            service.DownloadFiles("");
        }
    }
}
