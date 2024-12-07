namespace KidCon.WebApp.Helpers;

using System.Net.Http;

public class HttpResponseWrapper<T>(T response, bool success, HttpResponseMessage httpResponseMessage)
{
    public bool Success { get; set; } = success;

    public T Response { get; set; } = response;

    public HttpResponseMessage HttpResponseMessage { get; set; } = httpResponseMessage;
}