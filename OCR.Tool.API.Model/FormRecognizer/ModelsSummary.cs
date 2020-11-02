using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Summary of all trained custom models.
    /// </summary>
    [DataContract]
    public partial class ModelsSummary
    {
        /// <summary>
        /// Current count of trained custom models.
        /// </summary>
        /// <value>Current count of trained custom models.</value>
        [Required]
        [DataMember(Name = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Max number of models that can be trained for this subscription.
        /// </summary>
        /// <value>Max number of models that can be trained for this subscription.</value>
        [Required]
        [DataMember(Name = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Date and time (UTC) when the summary is last updated.
        /// </summary>
        /// <value>Date and time (UTC) when the summary is last updated.</value>
        [Required]
        [DataMember(Name = "lastUpdatedDateTime")]
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelsSummary {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  LastUpdatedDateTime: ").Append(LastUpdatedDateTime).Append("\n");
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