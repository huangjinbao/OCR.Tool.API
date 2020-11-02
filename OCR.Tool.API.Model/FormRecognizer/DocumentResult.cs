using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// A set of extracted fields corresponding to the input document.
    /// </summary>
    [DataContract]
    public partial class DocumentResult
    {
        /// <summary>
        /// Document type.
        /// </summary>
        /// <value>Document type.</value>
        [Required]
        [DataMember(Name = "docType")]
        public string DocType { get; set; }

        /// <summary>
        /// First and last page number where the document is found.
        /// </summary>
        /// <value>First and last page number where the document is found.</value>
        [Required]
        [DataMember(Name = "pageRange")]
        public List<int?> PageRange { get; set; }

        /// <summary>
        /// Dictionary of named field values.
        /// </summary>
        /// <value>Dictionary of named field values.</value>
        [Required]
        [DataMember(Name = "fields")]
        public Dictionary<string, FieldValue> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentResult {\n");
            sb.Append("  DocType: ").Append(DocType).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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