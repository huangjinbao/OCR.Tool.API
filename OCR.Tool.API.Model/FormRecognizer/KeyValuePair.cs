using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Information about the extracted key-value pair.
    /// </summary>
    [DataContract]
    public partial class KeyValuePair
    {
        /// <summary>
        /// A user defined label for the key/value pair entry.
        /// </summary>
        /// <value>A user defined label for the key/value pair entry.</value>
        [DataMember(Name = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Information about the extracted key in a key-value pair.
        /// </summary>
        /// <value>Information about the extracted key in a key-value pair.</value>
        [Required]
        [DataMember(Name = "key")]
        public KeyValueElement Key { get; set; }

        /// <summary>
        /// Information about the extracted value in a key-value pair.
        /// </summary>
        /// <value>Information about the extracted value in a key-value pair.</value>
        [Required]
        [DataMember(Name = "value")]
        public KeyValueElement Value { get; set; }

        /// <summary>
        /// Confidence value.
        /// </summary>
        /// <value>Confidence value.</value>
        [Required]
        [DataMember(Name = "confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyValuePair {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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