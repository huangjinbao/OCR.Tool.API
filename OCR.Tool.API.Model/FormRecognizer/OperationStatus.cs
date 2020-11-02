using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Status of the queued operation.
    /// </summary>
    /// <value>Status of the queued operation.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationStatus
    {
        /// <summary>
        /// Enum NotStartedEnum for notStarted
        /// </summary>
        [EnumMember(Value = "notStarted")]
        NotStartedEnum = 1,

        /// <summary>
        /// Enum RunningEnum for running
        /// </summary>
        [EnumMember(Value = "running")]
        RunningEnum = 2,

        /// <summary>
        /// Enum SucceededEnum for succeeded
        /// </summary>
        [EnumMember(Value = "succeeded")]
        SucceededEnum = 3,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 4
    }
}