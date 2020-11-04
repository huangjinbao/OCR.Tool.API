using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using OCR.Tool.API.FormRecognizer.Interface;
using OCR.Tool.API.FormRecognizer.Service;
using OCR.Tool.API.Model.FormRecognizer;
using OCR.Tool.API.Utils.ApiResult.Helper.Generic;
using OCR.Tool.API.Utils.ApiResult.Model.Generic;
using OCR.Tool.API.Utils.Async.Helper;
using Swashbuckle.AspNetCore.Annotations;

namespace OCR.Tool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormRecognizerController : ControllerBase
    {
        /// <summary>
        /// 传入文件获取文件OCR识别结果
        /// </summary>
        /// <remarks>
        /// <remarks>Extract text and layout information from a given document. The input document must be of one of the supported content types - &#39;application/pdf&#39;, &#39;image/jpeg&#39;, &#39;image/png&#39; or &#39;image/tiff&#39;. Alternatively, use &#39;application/json&#39; type to specify the Url location of the document to be analyzed.  &lt;br&gt;  Supported languages: The Layout API is currently only available for Dutch, English, French, German, Italian, Portuguese, Simplified Chinese and Spanish.</remarks>
        /// </remarks>
        /// <param name="file">.json, .pdf, .jpg, .png or .tiff type file</param>
        /// <param name="language">The BCP-47 language code of the text in the document. Currently, only English (&#39;en&#39;), Dutch (‘nl’), French (‘fr’), German (‘de’), Italian (‘it’), Portuguese (‘pt&#39;), simplified Chinese (&#39;zh-Hans&#39;) and Spanish (&#39;es&#39;) are supported (print – nine languages and handwritten – English only). Layout supports auto language identification and multilanguage documents, so only provide a language code if you would like to force the documented to be processed as that specific language.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("getAnalyzeLayoutContent")]
        [SwaggerOperation("GetAnalyzeLayoutContent")]
        public ApiResultModel<AnalyzeOperationResult> GetAnalyzeLayoutContent([Required] IFormFile file, [FromQuery] string language = "en")
        {
            try
            {
                if (file.Length == 0)
                {
                    throw new ValidationException("文件为空");
                }

                {
                    BufferedReadStream brs = new BufferedReadStream(file.OpenReadStream(), 0);
                    IFormRecognizerService formRecognizer = new FormRecognizerService();

                    // OCRServices OCRServices = new OCRServices();
                    var resultsUri = AsyncHelper.RunSync(() => formRecognizer.AnalyzeLayoutAsync(language, brs, file.ContentType));
                    var results = AsyncHelper.RunSync(() => formRecognizer.GetAnalazeInformation(resultsUri));
                    return new ApiResultHelper<AnalyzeOperationResult>().SuccessResult(results);
                }
            }
            catch (ValidationException e)
            {
                return new ApiResultHelper<AnalyzeOperationResult>().BadResult(e.Message);
            }
            catch (RequestFailedException e)
            {
                return new ApiResultHelper<AnalyzeOperationResult>().CustomResult(e.Message, e.Status);
            }
            catch (Exception e)
            {
                return new ApiResultHelper<AnalyzeOperationResult>().BadResult(e.Message);
            }
        }
    }
}