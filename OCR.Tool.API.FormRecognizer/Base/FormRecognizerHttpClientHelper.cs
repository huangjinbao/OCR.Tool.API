using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Azure;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Training;
using OCR.Tool.API.Common.ConfigurationConstant;
using OCR.Tool.API.Utils.HttpRestful.Helper;

namespace OCR.Tool.API.FormRecognizer.Base
{
    public class FormRecognizerHttpClientHelper
    {
        private static FormRecognizerClient FormRecognizerClient = null;

        private static readonly object FormRecognizerClient_Lock = new object();

        private static FormTrainingClient FormTrainingClient = null;

        protected static FormRecognizerClient GetFormRecognizerClient()
        {
            if (FormRecognizerClient == null)
            {
                lock (FormRecognizerClient_Lock)
                {
                    if (FormRecognizerClient == null)
                    {
                        var credential = new AzureKeyCredential(FormRecognizerConstant.FormRecognizerSubscriptionKey);
                        FormRecognizerClient = new FormRecognizerClient(new Uri(FormRecognizerConstant.FormRecognizerEndpoint), credential);
                    }
                }
            }

            return FormRecognizerClient;
        }

        protected static FormTrainingClient GetFormTrainingClient()
        {
            if (FormTrainingClient == null)
            {
                lock (FormRecognizerClient_Lock)
                {
                    if (FormTrainingClient == null)
                    {
                        var credential = new AzureKeyCredential(FormRecognizerConstant.FormRecognizerSubscriptionKey);
                        FormTrainingClient = new FormTrainingClient(new Uri(FormRecognizerConstant.FormRecognizerEndpoint), credential);
                    }
                }
            }

            return FormTrainingClient;
        }

        protected async Task<HttpResponseMessage> ExecuteAsync(string uri = null, HttpMethod method = null,
            IDictionary<string, string> headers = null,
            IDictionary<string, string> parameters = null,
            byte[] contentData = null, string contentType = "application/json")
        {
            RestfulHelper restful = new RestfulHelper();
            if (headers == null)
            {
                headers = new Dictionary<string, string>();
            }
            headers["Ocp-Apim-Subscription-Key"] = FormRecognizerConstant.FormRecognizerSubscriptionKey;
            var response = await restful.ExecuteAsync(uri, method, headers, parameters, null, contentData, contentType);
            return response;
        }

        public static FormContentType GetContentType(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
            {
                throw new ValidationException("contentType is null");
            }

            if (contentType.Equals("application/json"))
            {
                return FormContentType.Json;
            }

            if (contentType.Equals("application/pdf"))
            {
                return FormContentType.Pdf;
            }

            if (contentType.Equals("image/jpeg"))
            {
                return FormContentType.Jpeg;
            }

            if (contentType.Equals("image/png"))
            {
                return FormContentType.Jpeg;
            }

            if (contentType.Equals("image/tiff"))
            {
                return FormContentType.Tiff;
            }

            throw new ValidationException($"{contentType}:contentType can`t recognize");
        }
    }
}