using System.Net.Http;

namespace OCR.Tool.API.Utils.HttpRestful.HttpClientFactory
{
    public class HttpClientFactory
    {
        private static readonly HttpClient _httpClient = null;

        static HttpClientFactory()
        {
            _httpClient = new HttpClient(new HttpClientHandler());
        }

        public static HttpClient GetHttpClient()
        {
            return _httpClient;
        }
    }
}