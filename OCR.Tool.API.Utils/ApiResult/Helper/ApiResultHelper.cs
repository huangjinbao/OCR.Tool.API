using OCR.Tool.API.Utils.ApiResult.Model;
using System;
using System.Net;

namespace OCR.Tool.API.Utils.ApiResult.Helper
{
    /// <summary>
    /// 用来规范Api返回model
    /// </summary>
    public class ApiResultHelper
    {
        private readonly ApiResultModel result;

        public ApiResultHelper()
        {
            if (result == null)
            {
                result = new ApiResultModel();
            }
        }

        public ApiResultModel CustomResult(string message, int status)
        {
            if (status > -1)
            {
                result.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), status);
            }

            if (!string.IsNullOrEmpty(message))
            {
                result.Message = message;
            }

            return this.result;
        }

        public ApiResultModel SuccessResult(string message = "Http Request Success", int status = 200)
        {
            return this.CustomResult(message, status);
        }

        public ApiResultModel BadResult(string message = "Http Request Fail", int status = 400)
        {
            return this.CustomResult(message, status);
        }
    }
}