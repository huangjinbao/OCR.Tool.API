namespace OCR.Tool.API.Common.ConfigurationConstant
{
    public class BlobConstant : BaseConstant
    {
        public static readonly string StorageConnection = Configuration["Storage:StorageConnection"];

        public static readonly string StorageAccountKey = Configuration["Storage:StorageAccountKey"];

        public static readonly string StorageName = Configuration["Storage:StorageName"];

        public static readonly string StorageEndpoint = Configuration["Storage:StorageEndpoint"];

        public static readonly string TemplateModel = Configuration["Storage:TemplateModel"];

        public static readonly string Template = Configuration["Storage:Template"];

        public static readonly string FieldsAndTables = Configuration["Storage:FieldsAndTables"];

        public static readonly string ContainerName = Configuration["Storage:ContainerName"];

        public static readonly string TDKConfiguration = Configuration["Storage:TDKConfiguration"];

        public static readonly string SubscriptionKey = Configuration["FormRecognizer:SubscriptionKey"];

        public static readonly string FormRecognizerEndpoint = Configuration["FormRecognizer:FormRecognizerEndpoint"];

        public static readonly string TemporaryFilePath = Configuration["TemporaryFilePath"];
    }
}