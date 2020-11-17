using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Client.Helpers;

namespace ClientApp.Client.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        private JsonSerializerOptions defaultJsonSerializerOptions =>
           new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            try
            {
                var responseHTTP = await _httpClient.GetAsync(url);

                if (responseHTTP.IsSuccessStatusCode)
                {
                    var response = await responseHTTP.Content.ReadFromJsonAsync<T>();
                    return new HttpResponseWrapper<T>(response, true, responseHTTP);
                }
                else
                {
                    return new HttpResponseWrapper<T>(default, false, responseHTTP);
                }
            }
            catch (HttpRequestException ex) // Non success
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
                throw;
            }
            catch (JsonException ex) // Invalid JSON
            {
                Console.WriteLine($"Invalid JSON. {ex.Message}");
                throw;
            }
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsJsonAsync(url, stringContent);

            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage httpResponse, JsonSerializerOptions options)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, options);
        }
    }
}
