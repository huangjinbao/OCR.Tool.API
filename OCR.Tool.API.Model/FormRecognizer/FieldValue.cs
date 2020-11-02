using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Recognized field value.
    /// </summary>
    [DataContract]
    public partial class FieldValue
    {
        /// <summary>
        /// Type of field value.
        /// </summary>
        /// <value>Type of field value.</value>
        [Required]
        [DataMember(Name = "type")]
        public FieldValueType? Type { get; set; }

        /// <summary>
        /// String value.
        /// </summary>
        /// <value>String value.</value>
        [DataMember(Name = "valueString")]
        public string ValueString { get; set; }

        /// <summary>
        /// Date value.
        /// </summary>
        /// <value>Date value.</value>
        [DataMember(Name = "valueDate")]
        public DateTime? ValueDate { get; set; }

        /// <summary>
        /// Time value.
        /// </summary>
        /// <value>Time value.</value>
        [DataMember(Name = "valueTime")]
        public DateTime? ValueTime { get; set; }

        /// <summary>
        /// Phone number value.
        /// </summary>
        /// <value>Phone number value.</value>
        [DataMember(Name = "valuePhoneNumber")]
        public string ValuePhoneNumber { get; set; }

        /// <summary>
        /// Floating point value.
        /// </summary>
        /// <value>Floating point value.</value>
        [DataMember(Name = "valueNumber")]
        public decimal? ValueNumber { get; set; }

        /// <summary>
        /// Integer value.
        /// </summary>
        /// <value>Integer value.</value>
        [DataMember(Name = "valueInteger")]
        public int? ValueInteger { get; set; }

        /// <summary>
        /// Array of field values.
        /// </summary>
        /// <value>Array of field values.</value>
        [DataMember(Name = "valueArray")]
        public List<FieldValue> ValueArray { get; set; }

        /// <summary>
        /// Dictionary of named field values.
        /// </summary>
        /// <value>Dictionary of named field values.</value>
        [DataMember(Name = "valueObject")]
        public Dictionary<string, FieldValue> ValueObject { get; set; }

        /// <summary>
        /// Text content of the extracted field.
        /// </summary>
        /// <value>Text content of the extracted field.</value>
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Bounding box of the field value, if appropriate.
        /// </summary>
        /// <value>Bounding box of the field value, if appropriate.</value>
        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// Confidence score.
        /// </summary>
        /// <value>Confidence score.</value>
        [DataMember(Name = "confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// When includeTextDetails is set to true, a list of references to the text elements constituting this field.
        /// </summary>
        /// <value>When includeTextDetails is set to true, a list of references to the text elements constituting this field.</value>
        [DataMember(Name = "elements")]
        public List<ElementReference> Elements { get; set; }

        /// <summary>
        /// The 1-based page number in the input document.
        /// </summary>
        /// <value>The 1-based page number in the input document.</value>
        [DataMember(Name = "page")]
        public int? Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldValue {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValueString: ").Append(ValueString).Append("\n");
            sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
            sb.Append("  ValueTime: ").Append(ValueTime).Append("\n");
            sb.Append("  ValuePhoneNumber: ").Append(ValuePhoneNumber).Append("\n");
            sb.Append("  ValueNumber: ").Append(ValueNumber).Append("\n");
            sb.Append("  ValueInteger: ").Append(ValueInteger).Append("\n");
            sb.Append("  ValueArray: ").Append(ValueArray).Append("\n");
            sb.Append("  ValueObject: ").Append(ValueObject).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  BoundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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