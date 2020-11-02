using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Request parameter to copy an existing custom model.
    /// </summary>
    [DataContract]
    public partial class CopyRequest
    {
        /// <summary>
        /// Azure Resource Id of the target Form Recognizer resource where the model is copied to.
        /// </summary>
        /// <value>Azure Resource Id of the target Form Recognizer resource where the model is copied to.</value>
        [Required]
        [DataMember(Name = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Location of the target Azure resource.
        /// </summary>
        /// <value>Location of the target Azure resource.</value>
        [Required]
        [DataMember(Name = "targetResourceRegion")]
        public string TargetResourceRegion { get; set; }

        /// <summary>
        /// Entity that encodes claims to authorize the copy request.
        /// </summary>
        /// <value>Entity that encodes claims to authorize the copy request.</value>
        [Required]
        [DataMember(Name = "copyAuthorization")]
        public CopyAuthorizationResult CopyAuthorization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyRequest {\n");
            sb.Append("  TargetResourceId: ").Append(TargetResourceId).Append("\n");
            sb.Append("  TargetResourceRegion: ").Append(TargetResourceRegion).Append("\n");
            sb.Append("  CopyAuthorization: ").Append(CopyAuthorization).Append("\n");
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