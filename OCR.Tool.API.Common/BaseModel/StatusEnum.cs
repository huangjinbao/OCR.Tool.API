using System.Runtime.Serialization;

namespace OCR.Tool.API.Common.BaseModel
{
    /// <summary>
    /// Status of the model.
    /// </summary>
    /// <value>Status of the model.</value>
    [DataContract]
    public enum StatusEnum
    {
        /// <summary>
        /// Enum CreatingEnum for creating
        /// </summary>
        /// <value>Enum CreatingEnum for creating</value>
        [EnumMember(Value = "creating")]
        CreatingEnum = 1,

        /// <summary>
        /// Enum ReadyEnum for ready
        /// </summary>
        /// <value>Enum ReadyEnum for ready</value>
        [EnumMember(Value = "ready")]
        ReadyEnum = 2,

        /// <summary>
        /// Enum InvalidEnum for invalid
        /// </summary>
        /// <value>Enum InvalidEnum for invalid</value>
        [EnumMember(Value = "invalid")]
        InvalidEnum = 3,

        /// <summary>
        /// Enum InvalidEnum for succeeded
        /// </summary>
        /// <value>Enum InvalidEnum for succeeded</value>
        [EnumMember(Value = "succeeded")]
        SucceededEnum = 4
    }
}