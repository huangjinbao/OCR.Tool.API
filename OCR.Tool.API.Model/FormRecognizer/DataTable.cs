using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Information about the extracted table contained in a page.
    /// </summary>
    [DataContract]
    public partial class DataTable
    {
        /// <summary>
        /// Number of rows.
        /// </summary>
        /// <value>Number of rows.</value>
        [Required]
        [DataMember(Name = "rows")]
        public int? Rows { get; set; }

        /// <summary>
        /// Number of columns.
        /// </summary>
        /// <value>Number of columns.</value>
        [Required]
        [DataMember(Name = "columns")]
        public int? Columns { get; set; }

        /// <summary>
        /// List of cells contained in the table.
        /// </summary>
        /// <value>List of cells contained in the table.</value>
        [Required]
        [DataMember(Name = "cells")]
        public List<DataTableCell> Cells { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataTable {\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}