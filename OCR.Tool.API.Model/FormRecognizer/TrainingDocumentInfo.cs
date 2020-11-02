using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Report for a custom model training document.
    /// </summary>
    [DataContract]
    public partial class TrainingDocumentInfo
    {
        /// <summary>
        /// Training document name.
        /// </summary>
        /// <value>Training document name.</value>
        [Required]
        [DataMember(Name = "documentName")]
        public string DocumentName { get; set; }

        /// <summary>
        /// Total number of pages trained.
        /// </summary>
        /// <value>Total number of pages trained.</value>
        [Required]
        [DataMember(Name = "pages")]
        public int? Pages { get; set; }

        /// <summary>
        /// List of errors.
        /// </summary>
        /// <value>List of errors.</value>
        [Required]
        [DataMember(Name = "errors")]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Status of the training operation.
        /// </summary>
        /// <value>Status of the training operation.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum SucceededEnum for succeeded
            /// </summary>
            [EnumMember(Value = "succeeded")]
            SucceededEnum = 1,

            /// <summary>
            /// Enum PartiallySucceededEnum for partiallySucceeded
            /// </summary>
            [EnumMember(Value = "partiallySucceeded")]
            PartiallySucceededEnum = 2,

            /// <summary>
            /// Enum FailedEnum for failed
            /// </summary>
            [EnumMember(Value = "failed")]
            FailedEnum = 3
        }

        /// <summary>
        /// Status of the training operation.
        /// </summary>
        /// <value>Status of the training operation.</value>
        [Required]
        [DataMember(Name = "status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainingDocumentInfo {\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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