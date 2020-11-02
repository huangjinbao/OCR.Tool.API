using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// An object representing a word.
    /// </summary>
    [DataContract]
    public partial class TextWord
    {
        /// <summary>
        /// The text content of the word.
        /// </summary>
        /// <value>The text content of the word.</value>
        [Required]
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Bounding box of an extracted word.
        /// </summary>
        /// <value>Bounding box of an extracted word.</value>
        [Required]
        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

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
            sb.Append("class TextWord {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  BoundingBox: ").Append(BoundingBox).Append("\n");
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