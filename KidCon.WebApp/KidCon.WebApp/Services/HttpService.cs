namespace KidCon.WebApp.Services;

using System.Text;
using System.Text.Json;
using KidCon.WebApp.Helpers;

public class HttpService(HttpClient httpClient)
{
    private JsonSerializerOptions DefaultJsonSerializerOptions => new()
    {
        PropertyNameCaseInsensitive = true
    };

    public async Task<HttpResponseWrapper<T>> Get<T>(string url)
    {
        try
        {
            var responseHttp = await httpClient.GetAsync(url);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await responseHttp.Content.ReadFromJsonAsync<T>();
                return new HttpResponseWrapper<T>(response, true, responseHttp);
            }

            return new HttpResponseWrapper<T>(default, false, responseHttp);
        }
        catch (HttpRequestException) // Non success
        {
            Console.WriteLine("An error occurred.");
            throw;
        }
        catch (NotSupportedException) // When content type is not valid
        {
            Console.WriteLine("The content type is not supported.");
            throw;
        }
        catch (JsonException) // Invalid JSON
        {
            Console.WriteLine("Invalid JSON.");
            throw;
        }
    }

    public async Task<HttpResponseWrapper<object>> Post<T>(string url, T data)
    {
        var dataJson = JsonSerializer.Serialize(data);
        var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsJsonAsync(url, stringContent);

        return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
    }
}