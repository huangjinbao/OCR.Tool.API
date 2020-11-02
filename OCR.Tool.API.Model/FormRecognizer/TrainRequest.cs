using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Request parameter to train a new custom model.
    /// </summary>
    [DataContract]
    public partial class TrainRequest
    {
        /// <summary>
        /// Source path containing the training documents.
        /// </summary>
        /// <value>Source path containing the training documents.</value>
        [Required]
        [DataMember(Name = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Filter to apply to the documents in the source path for training.
        /// </summary>
        /// <value>Filter to apply to the documents in the source path for training.</value>
        [DataMember(Name = "sourceFilter")]
        public TrainSourceFilter SourceFilter { get; set; }

        /// <summary>
        /// Use label file for training a model.
        /// </summary>
        /// <value>Use label file for training a model.</value>
        [DataMember(Name = "useLabelFile")]
        public bool? UseLabelFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainRequest {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceFilter: ").Append(SourceFilter).Append("\n");
            sb.Append("  UseLabelFile: ").Append(UseLabelFile).Append("\n");
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