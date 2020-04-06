using System.Collections.Generic;
using System.Threading.Tasks;
using Kidcon.Shared;

namespace Kidcon.Client.Services
{
    public interface IEquationService
    {
        Task<string> GetRandomName();
    }
}