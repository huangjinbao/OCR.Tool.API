using System.Net;

namespace OCR.Tool.API.Utils.ApiResult.Model
{
    public class ApiResultModel
    {
        /// <summary>
        /// 状态代码
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }
    }
}