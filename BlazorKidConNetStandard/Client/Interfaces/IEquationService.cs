using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Shared;

namespace ClientApp.Client.Interfaces
{
    public interface IEquationService
    {
        Task<string> GetRandomName();
    }
}