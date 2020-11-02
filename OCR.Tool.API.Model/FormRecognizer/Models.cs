using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Response to the list custom models operation.
    /// </summary>
    [DataContract]
    public partial class Models
    {
        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary")]
        public ModelsSummary Summary { get; set; }

        /// <summary>
        /// Collection of trained custom models.
        /// </summary>
        /// <value>Collection of trained custom models.</value>
        [DataMember(Name = "modelList")]
        public List<ModelInfo> ModelList { get; set; }

        /// <summary>
        /// Link to the next page of custom models.
        /// </summary>
        /// <value>Link to the next page of custom models.</value>
        [DataMember(Name = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Models {\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  ModelList: ").Append(ModelList).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
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