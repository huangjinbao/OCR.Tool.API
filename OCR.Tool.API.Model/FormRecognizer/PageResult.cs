using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Extracted information from a single page.
    /// </summary>
    [DataContract]
    public partial class PageResult
    {
        /// <summary>
        /// Page number.
        /// </summary>
        /// <value>Page number.</value>
        [Required]
        [DataMember(Name = "page")]
        public int? Page { get; set; }

        /// <summary>
        /// Cluster identifier.
        /// </summary>
        /// <value>Cluster identifier.</value>
        [DataMember(Name = "clusterId")]
        public int? ClusterId { get; set; }

        /// <summary>
        /// List of key-value pairs extracted from the page.
        /// </summary>
        /// <value>List of key-value pairs extracted from the page.</value>
        [DataMember(Name = "keyValuePairs")]
        public List<KeyValuePair> KeyValuePairs { get; set; }

        /// <summary>
        /// List of data tables extracted from the page.
        /// </summary>
        /// <value>List of data tables extracted from the page.</value>
        [DataMember(Name = "tables")]
        public List<DataTable> Tables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageResult {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  KeyValuePairs: ").Append(KeyValuePairs).Append("\n");
            sb.Append("  Tables: ").Append(Tables).Append("\n");
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