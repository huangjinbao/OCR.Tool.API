using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace OCR.Tool.API.Model.FormRecognizer
{
    /// <summary>
    /// Semantic data type of the field value.
    /// </summary>
    /// <value>Semantic data type of the field value.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldValueType
    {
        /// <summary>
        /// Enum StringEnum for string
        /// </summary>
        [EnumMember(Value = "string")]
        StringEnum = 1,

        /// <summary>
        /// Enum DateEnum for date
        /// </summary>
        [EnumMember(Value = "date")]
        DateEnum = 2,

        /// <summary>
        /// Enum TimeEnum for time
        /// </summary>
        [EnumMember(Value = "time")]
        TimeEnum = 3,

        /// <summary>
        /// Enum PhoneNumberEnum for phoneNumber
        /// </summary>
        [EnumMember(Value = "phoneNumber")]
        PhoneNumberEnum = 4,

        /// <summary>
        /// Enum NumberEnum for number
        /// </summary>
        [EnumMember(Value = "number")]
        NumberEnum = 5,

        /// <summary>
        /// Enum IntegerEnum for integer
        /// </summary>
        [EnumMember(Value = "integer")]
        IntegerEnum = 6,

        /// <summary>
        /// Enum ArrayEnum for array
        /// </summary>
        [EnumMember(Value = "array")]
        ArrayEnum = 7,

        /// <summary>
        /// Enum ObjectEnum for object
        /// </summary>
        [EnumMember(Value = "object")]
        ObjectEnum = 8
    }
}