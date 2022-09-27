using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestSendRequest
{
    class Program
    {
        private static HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://contract.qiwigarant.com")
        };

        static async Task Main()
        {
            var inn = "2466190424";
            var response = await GetClientRequestsSum(inn);
        }
        
        public static async Task<string> GetClientRequestsSum(string inn)
        {
            try
            {
                var uri = $"/api/External/clientRequestsSum/{inn}";

                var response = await SendAsync(uri, HttpMethod.Get);

                var result = JsonConvert.DeserializeObject<string>(response.Content);
                

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private static async Task<(string Content, HttpStatusCode Code)> SendAsync(string uri, HttpMethod httpMethod, HttpContent httpContent = null)
        {
            using (var request = new HttpRequestMessage(httpMethod, uri))
            {
                if (httpContent != null)
                {
                    request.Content = httpContent;
                }

                var accessToken =
                    "eyJhbGciOiJSUzI1NiIsImtpZCI6IlpjS3FQNU5CcUhlZW9neDVScURDYVEiLCJ0eXAiOiJhdCtqd3QifQ.eyJuYmYiOjE2NjQyNzAzNzIsImV4cCI6MTY2NDI3Mzk3MiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5mYWN0b3JpbmdwbHVzLnJ1IiwiYXVkIjoiU3NvQWRtaW5DbGllbnRJZF9hcGkiLCJjbGllbnRfaWQiOiJTc29BZG1pbkNsaWVudElkX2FwaV9zd2FnZ2VydWkiLCJzY29wZSI6WyJTc29BZG1pbkNsaWVudElkX2FwaSJdfQ.emaCtqa53oCgv5pro20CqgY0BA0mwnTVFWlm_XncvVmabWI0N5qlgmH9nIlsZcnCPRGs13Vdz1bqvWTonaL-QvM6WoyuNikW39wrFps-PUMGQnCE1N2bkSsGxD3muffej4Dj_mIVdxZBA7_rvZHUcHp3DFOVLQuO6cs_UVgkW2R0_we-co9lkaU7X7Rxz9-3_WsAcM1VWvujGde0AmjqVykm03HjnXM4m-GDu0IrBN4-iHV-74JR-lhA-kMSkuO-6yVLkN3GNcJEt130zT_IJ5cxx3R222Q1nDJQlAFsTeoh6YOkM25K5-Yo6rnx5H3t6LuS3HsNc0LBfOpl31KWeg";

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                using (var response = await _httpClient.SendAsync(request))
                {
                    return (await response.Content.ReadAsStringAsync(), response.StatusCode);
                }
            }
        }
    }
}