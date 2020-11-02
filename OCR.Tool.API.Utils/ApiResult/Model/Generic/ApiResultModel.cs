namespace OCR.Tool.API.Utils.ApiResult.Model.Generic
{
    public class ApiResultModel<T> : ApiResultModel
    {
        /// <summary>
        /// 返回的数据
        /// </summary>
        public T Data { get; set; }
    }
}