using Azure.Storage;
using Azure.Storage.Blobs;

namespace FileMigration.Helpers.AzureBlob
{
    public static class AzureBlobHelper
    {
        public const string ACCOUNT_NAME = "";
        public const string ACCOUNT_KEY = "";
        public const string SAS_TOKEN = "";
        public const string CONNECTION_STRING = "";

        public static BlobClient GetBlobClientByContainerName(string name, string blobName) =>
            GetBlobContainerClientByContainerName(name).GetBlobClient(blobName);

        public static BlobClient GetBlobClientWithSasTokenByContainerName(string name, string blobName) =>
            GetBlobContainerClientWithSasTokenByContainerName(name).GetBlobClient(blobName);

        public static BlobClient GetBlobClientWithConnectionStringByContainerName(string name, string blobName) =>
            GetBlobContainerClientWithConnectionStringByContainerName(name).GetBlobClient(blobName);

        public static BlobContainerClient GetBlobContainerClientByContainerName(string name) =>
            GenerateBlobServiceClient().GetBlobContainerClient(name);

        public static BlobContainerClient GetBlobContainerClientWithSasTokenByContainerName(string name) =>
            GenerateBlobServiceClientBySasToken().GetBlobContainerClient(name);

        public static BlobContainerClient GetBlobContainerClientWithConnectionStringByContainerName(string name) =>
           GenerateBlobServiceClientByConnectionString().GetBlobContainerClient(name);

        public static BlobServiceClient GenerateBlobServiceClient() =>
            new(new Uri(GetBlobUri()), GenerateStorageSharedKeyCredential());

        public static BlobServiceClient GenerateBlobServiceClientBySasToken() =>
            new(new Uri($"{GetBlobUri()}?{SAS_TOKEN}"));

        public static BlobServiceClient GenerateBlobServiceClientByConnectionString() =>
             new(CONNECTION_STRING);

        public static StorageSharedKeyCredential GenerateStorageSharedKeyCredential() =>
            new (ACCOUNT_NAME, ACCOUNT_KEY);

        public static string GetBlobUri() =>
            $"https://{ACCOUNT_NAME}.blob.core.windows.net";
    }
}
