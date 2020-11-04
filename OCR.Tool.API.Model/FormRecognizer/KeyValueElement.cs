using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Information about the extracted key or value in a key-value pair.
    /// </summary>
    [DataContract]
    public partial class KeyValueElement
    {
        /// <summary>
        /// The text content of the key or value.
        /// </summary>
        /// <value>The text content of the key or value.</value>
        [Required]
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Bounding box of the key or value.
        /// </summary>
        /// <value>Bounding box of the key or value.</value>
        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// When includeTextDetails is set to true, a list of references to the text elements constituting this key or value.
        /// </summary>
        /// <value>When includeTextDetails is set to true, a list of references to the text elements constituting this key or value.</value>
        [DataMember(Name = "elements")]
        public List<string> Elements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyValueElement {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  BoundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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