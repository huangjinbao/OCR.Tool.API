namespace OCR.Tool.API.Common.ConfigurationConstant
{
    public class StorageConstant : BaseConstant
    {
        public static readonly string StorageConnection = Configuration["Storage:StorageConnection"];

        public static readonly string StorageAccountKey = Configuration["Storage:StorageAccountKey"];

        public static readonly string StorageName = Configuration["Storage:StorageName"];

        public static readonly string StorageEndpoint = Configuration["Storage:StorageEndpoint"];

        public static readonly string ContainerName = Configuration["Storage:ContainerName"];
    }
}