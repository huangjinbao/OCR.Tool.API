using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Tool.API.Utils.HttpRestful.Helper
{
    public class RestfulHelper
    {
        public async Task<HttpResponseMessage> ExecuteAsync(
            string uri = null,
            HttpMethod method = null,
            IDictionary<string, string> headers = null,
            IDictionary<string, string> parameters = null,
            AuthenticationHeaderValue authorization = null,
            byte[] contentData = null,
            string contentType = null
        )
        {
            if (method == HttpMethod.Get)
                return await this.ExecuteAsync(async (c, u, b) => await c.GetAsync(u), uri, headers, parameters, authorization);
            if (method == HttpMethod.Post)
                return await this.ExecuteAsync(async (c, u, b) => await c.PostAsync(u, b), uri, headers, parameters, authorization, contentData, contentType);
            if (contentData == null)
            {
                return await this.ExecuteAsync(async (c, u, b) => await c.SendAsync(new HttpRequestMessage(method, u)), uri, headers, parameters, authorization);
            }
            return await this.ExecuteAsync(async (c, u, b) => await c.SendAsync(new HttpRequestMessage
            {
                Method = method,
                RequestUri = u,
                Content = b
            }), uri, headers, parameters, authorization, contentData, contentType);
        }

        public async Task<T> ExecuteAsync<T>(
            Func<HttpClient, Uri, ByteArrayContent, Task<T>> func = null,
            string uri = null,
            IDictionary<string, string> headers = null,
            IDictionary<string, string> parameters = null,
            AuthenticationHeaderValue authorization = null,
            byte[] contentData = null,
            string contentType = null
            )
        {
            try
            {
                T response;
                {
                    var client = HttpClientFactory.HttpClientFactory.GetHttpClient();
                    ServicePointManager.MaxServicePointIdleTime = 5000;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    //Headers
                    if (headers != null && headers.Count > 0)
                    {
                        foreach (var key in headers.Keys)
                        {
                            client.DefaultRequestHeaders.Add(key, headers[key]);
                        }
                    }

                    //设置授权信息
                    if (authorization != null)
                    {
                        client.DefaultRequestHeaders.Authorization = authorization;
                    }

                    // 参数数据
                    if (parameters != null && parameters.Count > 0)
                    {
                        StringBuilder buffer = new StringBuilder();
                        var i = 0;
                        foreach (string key in parameters.Keys)
                        {
                            buffer.AppendFormat(i > 0 ? "&{0}={1}" : "?{0}={1}", key, parameters[key]);
                            i++;
                        }
                        uri += buffer.ToString();
                    }

                    var fullUri = new Uri(uri);

                    if (contentData == null)
                    {
                        response = await func.Invoke(client, fullUri, null);
                    }
                    else
                    {
                        using (var content = new ByteArrayContent(contentData))
                        {
                            if (!string.IsNullOrEmpty(contentType))
                            {
                                content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                            }
                            response = await func.Invoke(client, fullUri, content);
                        }
                    }
                }
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine(e);
                throw new WebException(e.ToString(), e);
            }
        }
    }
}