using BlazorKidConApp.Client.Helpers;
using System;
using System.Threading.Tasks;

namespace BlazorKidConApp.Client.Interfaces
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T data);
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
    }
}
