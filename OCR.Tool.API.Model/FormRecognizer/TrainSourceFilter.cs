using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Filter to apply to the documents in the source path for training.
    /// </summary>
    [DataContract]
    public partial class TrainSourceFilter
    {
        /// <summary>
        /// A case-sensitive prefix string to filter documents in the source path for training. For example, when using a Azure storage blob Uri, use the prefix to restrict sub folders for training.
        /// </summary>
        /// <value>A case-sensitive prefix string to filter documents in the source path for training. For example, when using a Azure storage blob Uri, use the prefix to restrict sub folders for training.</value>
        [DataMember(Name = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// A flag to indicate if sub folders within the set of prefix folders will also need to be included when searching for content to be preprocessed.
        /// </summary>
        /// <value>A flag to indicate if sub folders within the set of prefix folders will also need to be included when searching for content to be preprocessed.</value>
        [DataMember(Name = "includeSubFolders")]
        public bool? IncludeSubFolders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainSourceFilter {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  IncludeSubFolders: ").Append(IncludeSubFolders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}