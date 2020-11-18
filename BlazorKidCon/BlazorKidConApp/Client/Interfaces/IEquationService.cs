using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorKidConApp.Client.Interfaces
{
    public interface IEquationService
    {
        Task<string> GetRandomName();
    }
}