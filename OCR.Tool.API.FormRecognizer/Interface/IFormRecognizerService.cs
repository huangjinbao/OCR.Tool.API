using System.IO;
using System.Threading.Tasks;
using OCR.Tool.API.Model.FormRecognizer;

namespace OCR.Tool.API.FormRecognizer.Interface
{
    public interface IFormRecognizerService
    {
        /// <summary>
        /// Analyze Layout - Analyze Layout
        /// </summary>
        /// <remarks>Extract text and layout information from a given document. The input document must be of one of the supported content types - &#39;application/pdf&#39;, &#39;image/jpeg&#39;, &#39;image/png&#39; or &#39;image/tiff&#39;. Alternatively, use &#39;application/json&#39; type to specify the Url location of the document to be analyzed.  &lt;br&gt;  Supported languages: The Layout API is currently only available for Dutch, English, French, German, Italian, Portuguese, Simplified Chinese and Spanish.</remarks>
        /// <param name="language">The BCP-47 language code of the text in the document. Currently, only English (&#39;en&#39;), Dutch (‘nl’), French (‘fr’), German (‘de’), Italian (‘it’), Portuguese (‘pt&#39;), simplified Chinese (&#39;zh-Hans&#39;) and Spanish (&#39;es&#39;) are supported (print – nine languages and handwritten – English only). Layout supports auto language identification and multilanguage documents, so only provide a language code if you would like to force the documented to be processed as that specific language.</param>
        /// <param name="stream">.json, .pdf, .jpg, .png or .tiff type file stream.</param>
        /// <param name="contentType">.json, .pdf, .jpg, .png or .tiff</param>
        /// <returns></returns>
        public Task<string> AnalyzeLayoutAsync(string language, Stream stream, string contentType);

        public Task<AnalyzeOperationResult> GetAnalazeInformation(string uri);
    }
}