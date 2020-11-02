using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Custom model copy result.
    /// </summary>
    [DataContract]
    public partial class CopyResult
    {
        /// <summary>
        /// Identifier of the model in the target subscription after the copy operation.
        /// </summary>
        /// <value>Identifier of the model in the target subscription after the copy operation.</value>
        [Required]
        [DataMember(Name = "modelId")]
        public Guid? ModelId { get; set; }

        /// <summary>
        /// Errors returned during the copy operation.
        /// </summary>
        /// <value>Errors returned during the copy operation.</value>
        [DataMember(Name = "errors")]
        public List<ErrorInformation> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyResult {\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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