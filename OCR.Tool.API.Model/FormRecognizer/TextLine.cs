using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// An object representing an extracted text line.
    /// </summary>
    [DataContract]
    public partial class TextLine
    {
        /// <summary>
        /// The text content of the line.
        /// </summary>
        /// <value>The text content of the line.</value>
        [Required]
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Bounding box of an extracted line.
        /// </summary>
        /// <value>Bounding box of an extracted line.</value>
        [Required]
        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// List of words in the text line.
        /// </summary>
        /// <value>List of words in the text line.</value>
        [Required]
        [DataMember(Name = "words")]
        public List<TextWord> Words { get; set; }
    }
}