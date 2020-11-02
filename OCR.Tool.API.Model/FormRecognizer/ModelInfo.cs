using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Basic custom model information.
    /// </summary>
    [DataContract]
    public partial class ModelInfo
    {
        /// <summary>
        /// Model identifier.
        /// </summary>
        /// <value>Model identifier.</value>
        [Required]
        [DataMember(Name = "modelId")]
        public Guid? ModelId { get; set; }

        /// <summary>
        /// Status of the model.
        /// </summary>
        /// <value>Status of the model.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum CreatingEnum for creating
            /// </summary>
            [EnumMember(Value = "creating")]
            CreatingEnum = 1,

            /// <summary>
            /// Enum ReadyEnum for ready
            /// </summary>
            [EnumMember(Value = "ready")]
            ReadyEnum = 2,

            /// <summary>
            /// Enum InvalidEnum for invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            InvalidEnum = 3
        }

        /// <summary>
        /// Status of the model.
        /// </summary>
        /// <value>Status of the model.</value>
        [Required]
        [DataMember(Name = "status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Date and time (UTC) when the model was created.
        /// </summary>
        /// <value>Date and time (UTC) when the model was created.</value>
        [Required]
        [DataMember(Name = "createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Date and time (UTC) when the status is last updated.
        /// </summary>
        /// <value>Date and time (UTC) when the status is last updated.</value>
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
            sb.Append("class ModelInfo {\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
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