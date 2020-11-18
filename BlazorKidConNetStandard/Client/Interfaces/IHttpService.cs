using System;
using System.Threading.Tasks;
using ClientApp.Client.Helpers;

namespace ClientApp.Client.Services
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T data);
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
    }
}
