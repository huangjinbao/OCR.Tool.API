using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Analyze operation result.
    /// </summary>
    [DataContract]
    public partial class AnalyzeResult
    {
        /// <summary>
        /// Version of schema used for this result.
        /// </summary>
        /// <value>Version of schema used for this result.</value>
        [Required]
        [DataMember(Name = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Text extracted from the input.
        /// </summary>
        /// <value>Text extracted from the input.</value>
        [Required]
        [DataMember(Name = "readResults")]
        public List<ReadResult> ReadResults { get; set; }

        /// <summary>
        /// Page-level information extracted from the input.
        /// </summary>
        /// <value>Page-level information extracted from the input.</value>
        [DataMember(Name = "pageResults")]
        public List<PageResult> PageResults { get; set; }

        /// <summary>
        /// Document-level information extracted from the input.
        /// </summary>
        /// <value>Document-level information extracted from the input.</value>
        [DataMember(Name = "documentResults")]
        public List<DocumentResult> DocumentResults { get; set; }

        /// <summary>
        /// List of errors reported during the analyze operation.
        /// </summary>
        /// <value>List of errors reported during the analyze operation.</value>
        [DataMember(Name = "errors")]
        public List<FormOperationError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzeResult {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ReadResults: ").Append(ReadResults).Append("\n");
            sb.Append("  PageResults: ").Append(PageResults).Append("\n");
            sb.Append("  DocumentResults: ").Append(DocumentResults).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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