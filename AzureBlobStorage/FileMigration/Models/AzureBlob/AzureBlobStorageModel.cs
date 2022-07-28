namespace FileMigration.Models.AzureBlob
{
    public class AzureBlobStorageModel
    {
        public string ContainerName { get; private set; }
        public string BlobName { get; private set; }
        public AzureBlobStorageCopyModel AzureBlobStorageCopy { get; private set; }

        public AzureBlobStorageModel SetBlobStorageCopy(AzureBlobStorageCopyModel azureBlobStorageCopy)
        {
            AzureBlobStorageCopy = azureBlobStorageCopy;
            return this;
        }

        public AzureBlobStorageModel SetContainerName(string containerName)
        {
            ContainerName = containerName;
            return this;
        }

        public AzureBlobStorageModel SetBlobName(string blobName)
        {
            BlobName = blobName;
            return this;
        }
    }
}
