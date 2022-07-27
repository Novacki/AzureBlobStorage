using Azure.Storage;
using Azure.Storage.Blobs;

namespace FileMigration.Helpers.AzureBlob
{
    public static class AzureBlobHelper
    {
        public const string ACCOUNT_NAME = "";
        public const string ACCOUNT_KEY = "";
        public const string CONNECTION_STRING = "";
        public static BlobServiceClient GenerateBlobServiceClient() =>
            new(new Uri(GetBlobUri()), GenerateStorageSharedKeyCredential());
        public static BlobServiceClient GenerateBlobServiceClientByConnectionString() =>
             new(CONNECTION_STRING);
        public static StorageSharedKeyCredential GenerateStorageSharedKeyCredential() =>
            new (ACCOUNT_NAME, ACCOUNT_KEY);
        public static string GetBlobUri() =>
            $"https://{ACCOUNT_NAME}.blob.core.windows.net";
    }
}
