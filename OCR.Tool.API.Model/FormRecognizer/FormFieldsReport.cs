using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Report for a custom model training field.
    /// </summary>
    [DataContract]
    public partial class FormFieldsReport
    {
        /// <summary>
        /// Training field name.
        /// </summary>
        /// <value>Training field name.</value>
        [Required]
        [DataMember(Name = "fieldName")]
        public string FieldName { get; set; }

        /// <summary>
        /// Estimated extraction accuracy for this field.
        /// </summary>
        /// <value>Estimated extraction accuracy for this field.</value>
        [Required]
        [DataMember(Name = "accuracy")]
        public decimal? Accuracy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormFieldsReport {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
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