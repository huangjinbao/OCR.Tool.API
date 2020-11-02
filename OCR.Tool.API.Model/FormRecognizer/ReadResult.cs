using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Text extracted from a page in the input document.
    /// </summary>
    [DataContract]
    public partial class ReadResult
    {
        /// <summary>
        /// The 1-based page number in the input document.
        /// </summary>
        /// <value>The 1-based page number in the input document.</value>
        [Required]
        [DataMember(Name = "page")]
        public int? Page { get; set; }

        /// <summary>
        /// The general orientation of the text in clockwise direction, measured in degrees between (-180, 180].
        /// </summary>
        /// <value>The general orientation of the text in clockwise direction, measured in degrees between (-180, 180].</value>
        [Required]
        [DataMember(Name = "angle")]
        public decimal? Angle { get; set; }

        /// <summary>
        /// The width of the image/PDF in pixels/inches, respectively.
        /// </summary>
        /// <value>The width of the image/PDF in pixels/inches, respectively.</value>
        [Required]
        [DataMember(Name = "width")]
        public decimal? Width { get; set; }

        /// <summary>
        /// The height of the image/PDF in pixels/inches, respectively.
        /// </summary>
        /// <value>The height of the image/PDF in pixels/inches, respectively.</value>
        [Required]
        [DataMember(Name = "height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// The unit used by the width, height and boundingBox properties. For images, the unit is \"pixel\". For PDF, the unit is \"inch\".
        /// </summary>
        /// <value>The unit used by the width, height and boundingBox properties. For images, the unit is \"pixel\". For PDF, the unit is \"inch\".</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum PixelEnum for pixel
            /// </summary>
            [EnumMember(Value = "pixel")]
            PixelEnum = 1,

            /// <summary>
            /// Enum InchEnum for inch
            /// </summary>
            [EnumMember(Value = "inch")]
            InchEnum = 2
        }

        /// <summary>
        /// The unit used by the width, height and boundingBox properties. For images, the unit is \\&quot;pixel\\&quot;. For PDF, the unit is \\&quot;inch\\&quot;.
        /// </summary>
        /// <value>The unit used by the width, height and boundingBox properties. For images, the unit is \\&quot;pixel\\&quot;. For PDF, the unit is \\&quot;inch\\&quot;.</value>
        [Required]
        [DataMember(Name = "unit")]
        public UnitEnum? Unit { get; set; }

        /// <summary>
        /// When includeTextDetails is set to true, a list of recognized text lines. The maximum number of lines returned is 300 per page. The lines are sorted top to bottom, left to right, although in certain cases proximity is treated with higher priority. As the sorting order depends on the detected text, it may change across images and OCR version updates. Thus, business logic should be built upon the actual line location instead of order.
        /// </summary>
        /// <value>When includeTextDetails is set to true, a list of recognized text lines. The maximum number of lines returned is 300 per page. The lines are sorted top to bottom, left to right, although in certain cases proximity is treated with higher priority. As the sorting order depends on the detected text, it may change across images and OCR version updates. Thus, business logic should be built upon the actual line location instead of order.</value>
        [DataMember(Name = "lines")]
        public List<TextLine> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReadResult {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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