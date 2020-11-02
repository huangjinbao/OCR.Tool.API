using System;
using System.Runtime.Serialization;

namespace OCR.Tool.API.Common.BaseModel
{
    [DataContract]
    public class BaseStatusModel
    {
        /// <summary>
        /// file status .
        /// </summary>
        /// <value>file status .</value>
        [DataMember(Name = "status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Date and time (UTC) when the file was created.
        /// </summary>
        /// <value>Date and time (UTC) when the file was created.</value>
        [DataMember(Name = "createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Date and time (UTC) when the status is last updated.
        /// </summary>
        /// <value>Date and time (UTC) when the status is last updated.</value>
        [DataMember(Name = "lastUpdatedDateTime")]
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}