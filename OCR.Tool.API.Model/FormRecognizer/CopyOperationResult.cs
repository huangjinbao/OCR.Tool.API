using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Status and result of the queued copy operation.
    /// </summary>
    [DataContract]
    public partial class CopyOperationResult
    {
        /// <summary>
        /// Operation status.
        /// </summary>
        /// <value>Operation status.</value>
        [Required]
        [DataMember(Name = "status")]
        public OperationStatus? Status { get; set; }

        /// <summary>
        /// Date and time (UTC) when the copy operation was submitted.
        /// </summary>
        /// <value>Date and time (UTC) when the copy operation was submitted.</value>
        [Required]
        [DataMember(Name = "createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Date and time (UTC) when the status was last updated.
        /// </summary>
        /// <value>Date and time (UTC) when the status was last updated.</value>
        [Required]
        [DataMember(Name = "lastUpdatedDateTime")]
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Results of the copy operation.
        /// </summary>
        /// <value>Results of the copy operation.</value>
        [DataMember(Name = "copyResult")]
        public CopyResult CopyResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyOperationResult {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastUpdatedDateTime: ").Append(LastUpdatedDateTime).Append("\n");
            sb.Append("  CopyResult: ").Append(CopyResult).Append("\n");
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