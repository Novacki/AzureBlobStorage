namespace FileMigration.Models.AzureBlob
{
    public class AzureBlobStorageCopyModel
    {
        public AzureBlobStorageCopyModel(string containerOriginName, string containerDestinationName)
        {
            ContainerOriginName = containerOriginName;
            ContainerDestinationName = containerDestinationName;
        }

        public string ContainerOriginName { get; private set; }
        public string ContainerDestinationName { get; private set; }

    }
}
