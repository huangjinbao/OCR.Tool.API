using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Response to the get custom model operation.
    /// </summary>
    [DataContract]
    public partial class Model
    {
        /// <summary>
        /// Basic custom model information.
        /// </summary>
        /// <value>Basic custom model information.</value>
        [Required]
        [DataMember(Name = "modelInfo")]
        public ModelInfo ModelInfo { get; set; }

        /// <summary>
        /// Keys extracted by the custom model.
        /// </summary>
        /// <value>Keys extracted by the custom model.</value>
        [DataMember(Name = "keys")]
        public KeysResult Keys { get; set; }

        /// <summary>
        /// Custom model training result.
        /// </summary>
        /// <value>Custom model training result.</value>
        [DataMember(Name = "trainResult")]
        public TrainResult TrainResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model {\n");
            sb.Append("  ModelInfo: ").Append(ModelInfo).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  TrainResult: ").Append(TrainResult).Append("\n");
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