using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer;
using Newtonsoft.Json;
using OCR.Tool.API.Common.ConfigurationConstant;
using OCR.Tool.API.FormRecognizer.Base;
using OCR.Tool.API.FormRecognizer.Interface;
using OCR.Tool.API.Model.FormRecognizer;
using OCR.Tool.API.Utils.StreamToByte.Helper;

namespace OCR.Tool.API.FormRecognizer.Service
{
    public class FormRecognizerService : FormRecognizerHttpClientHelper, IFormRecognizerService
    {
        public async Task<string> AnalyzeLayoutAsync(string language, Stream stream, string contentType = "application/pdf")
        {
            var requestUri = $"{FormRecognizerConstant.FormRecognizerEndpoint}formrecognizer/{FormRecognizerConstant.FormRecognizerVersion}/layout/analyze";

            IDictionary<string, string> parameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(language))
            {
                parameters["language"] = language;
            }

            var byteDatas = StreamToByteHelper.StreamToBytes(stream);

            var analyzeLayoutesult = await base.ExecuteAsync(requestUri, HttpMethod.Post, null, parameters, byteDatas, contentType);
            //var trainResult = await base.FormExecuteAsync(testUri, HttpMethod.Get);

            if (!analyzeLayoutesult.IsSuccessStatusCode)
            {
                throw new ValidationException("AnalyzeLayoutAsync fail");
            }

            var values = analyzeLayoutesult.Headers.GetValues("Operation-Location").ToArray();
            if (string.IsNullOrEmpty(values[0]))
            {
                throw new ValidationException("AnalyzeLayoutAsync fail");
            }

            return values[0];
        }

        public async Task<AnalyzeOperationResult> GetAnalazeInformation(string uri)
        {
            CancellationTokenSource cancellation = new CancellationTokenSource();
            AnalyzeOperationResult result = new AnalyzeOperationResult();
            while (!cancellation.IsCancellationRequested)
            {
                var content = await base.ExecuteAsync(uri, HttpMethod.Get);

                if (content.Content == null)
                {
                    throw new ValidationException("file analyze is empty");
                }

                var analyze = await content.Content?.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<AnalyzeOperationResult>(analyze);

                //检查分析是否执行完成
                if (result.Status == OperationStatus.SucceededEnum || result.Status == OperationStatus.FailedEnum)
                {
                    cancellation.Cancel();
                }
                else
                {
                    //每过1秒重新查询是否分析文件完毕
                    Thread.Sleep(1000);
                }
            }

            return result;
        }
    }
}