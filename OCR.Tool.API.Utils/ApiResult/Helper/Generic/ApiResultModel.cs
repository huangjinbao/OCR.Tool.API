using OCR.Tool.API.Utils.ApiResult.Model.Generic;
using System;
using System.Net;

namespace OCR.Tool.API.Utils.ApiResult.Helper.Generic
{
    public class ApiResultHelper<T>
    {
        public ApiResultModel<T> result;

        public ApiResultHelper()
        {
            if (result == null)
            {
                result = new ApiResultModel<T>();
            }
        }

        public ApiResultModel<T> CustomResult(string message, int status, T data = default)
        {
            if (status > -1)
            {
                result.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), status);
            }

            if (!string.IsNullOrEmpty(message))
            {
                result.Message = message;
            }

            if (data != null)
            {
                result.Data = data;
            }

            return this.result;
        }

        public ApiResultModel<T> SuccessResult(T data = default, string message = "Http Request Success", int status = 200)
        {
            return this.CustomResult(message, status, data);
        }

        public ApiResultModel<T> BadResult(string message = "Http Request Fail", int status = 400)
        {
            return this.CustomResult(message, status, default);
        }
    }
}