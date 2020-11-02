using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Custom model training result.
    /// </summary>
    [DataContract]
    public partial class TrainResult
    {
        /// <summary>
        /// List of the documents used to train the model and any errors reported in each document.
        /// </summary>
        /// <value>List of the documents used to train the model and any errors reported in each document.</value>
        [Required]
        [DataMember(Name = "trainingDocuments")]
        public List<TrainingDocumentInfo> TrainingDocuments { get; set; }

        /// <summary>
        /// List of fields used to train the model and the train operation error reported by each.
        /// </summary>
        /// <value>List of fields used to train the model and the train operation error reported by each.</value>
        [DataMember(Name = "fields")]
        public List<FormFieldsReport> Fields { get; set; }

        /// <summary>
        /// Average accuracy.
        /// </summary>
        /// <value>Average accuracy.</value>
        [DataMember(Name = "averageModelAccuracy")]
        public decimal? AverageModelAccuracy { get; set; }

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        /// <value>Errors returned during the training operation.</value>
        [DataMember(Name = "errors")]
        public List<FormOperationError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainResult {\n");
            sb.Append("  TrainingDocuments: ").Append(TrainingDocuments).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  AverageModelAccuracy: ").Append(AverageModelAccuracy).Append("\n");
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