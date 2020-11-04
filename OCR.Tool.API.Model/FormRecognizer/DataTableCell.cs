using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Information about the extracted cell in a table.
    /// </summary>
    [DataContract]
    public partial class DataTableCell
    {
        /// <summary>
        /// Row index of the cell.
        /// </summary>
        /// <value>Row index of the cell.</value>
        [Required]
        [DataMember(Name = "rowIndex")]
        public int? RowIndex { get; set; }

        /// <summary>
        /// Column index of the cell.
        /// </summary>
        /// <value>Column index of the cell.</value>
        [Required]
        [DataMember(Name = "columnIndex")]
        public int? ColumnIndex { get; set; }

        /// <summary>
        /// Number of rows spanned by this cell.
        /// </summary>
        /// <value>Number of rows spanned by this cell.</value>
        [DataMember(Name = "rowSpan")]
        public int? RowSpan { get; set; }

        /// <summary>
        /// Number of columns spanned by this cell.
        /// </summary>
        /// <value>Number of columns spanned by this cell.</value>
        [DataMember(Name = "columnSpan")]
        public int? ColumnSpan { get; set; }

        /// <summary>
        /// Text content of the cell.
        /// </summary>
        /// <value>Text content of the cell.</value>
        [Required]
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Bounding box of the cell.
        /// </summary>
        /// <value>Bounding box of the cell.</value>
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
        /// When includeTextDetails is set to true, a list of references to the text elements constituting this table cell.
        /// </summary>
        /// <value>When includeTextDetails is set to true, a list of references to the text elements constituting this table cell.</value>
        [DataMember(Name = "elements")]
        public List<string> Elements { get; set; }

        /// <summary>
        /// Is the current cell a header cell?
        /// </summary>
        /// <value>Is the current cell a header cell?</value>
        [DataMember(Name = "isHeader")]
        public bool? IsHeader { get; set; }

        /// <summary>
        /// Is the current cell a footer cell?
        /// </summary>
        /// <value>Is the current cell a footer cell?</value>
        [DataMember(Name = "isFooter")]
        public bool? IsFooter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataTableCell {\n");
            sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
            sb.Append("  ColumnIndex: ").Append(ColumnIndex).Append("\n");
            sb.Append("  RowSpan: ").Append(RowSpan).Append("\n");
            sb.Append("  ColumnSpan: ").Append(ColumnSpan).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  BoundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
            sb.Append("  IsHeader: ").Append(IsHeader).Append("\n");
            sb.Append("  IsFooter: ").Append(IsFooter).Append("\n");
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