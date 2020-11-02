using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Request parameter that contains authorization claims for copy operation.
    /// </summary>
    [DataContract]
    public partial class CopyAuthorizationResult
    {
        /// <summary>
        /// Model identifier.
        /// </summary>
        /// <value>Model identifier.</value>
        [Required]
        [DataMember(Name = "modelId")]
        public string ModelId { get; set; }

        /// <summary>
        /// Token claim used to authorize the request.
        /// </summary>
        /// <value>Token claim used to authorize the request.</value>
        [Required]
        [DataMember(Name = "accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The date and time (in UTC) when the access token expires. Represented as the number of seconds from 1970-01-01T0:0:0Z UTC until the expiration time.
        /// </summary>
        /// <value>The date and time (in UTC) when the access token expires. Represented as the number of seconds from 1970-01-01T0:0:0Z UTC until the expiration time.</value>
        [Required]
        [DataMember(Name = "expirationDateTimeTicks")]
        public long? ExpirationDateTimeTicks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyAuthorizationResult {\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpirationDateTimeTicks: ").Append(ExpirationDateTimeTicks).Append("\n");
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