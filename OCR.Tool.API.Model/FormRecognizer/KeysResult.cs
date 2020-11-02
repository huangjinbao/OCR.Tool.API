using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Keys extracted by the custom model.
    /// </summary>
    [DataContract]
    public partial class KeysResult
    {
        /// <summary>
        /// Object mapping clusterIds to a list of keys.
        /// </summary>
        /// <value>Object mapping clusterIds to a list of keys.</value>
        [Required]
        [DataMember(Name = "clusters")]
        public Dictionary<string, List<string>> Clusters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeysResult {\n");
            sb.Append("  Clusters: ").Append(Clusters).Append("\n");
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