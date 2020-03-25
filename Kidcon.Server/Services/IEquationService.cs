using System.Collections.Generic;
using System.Threading.Tasks;
using Kidcon.Shared;

namespace Kidcon.Server.Services
{
    public interface IEquationService
    {
        Task<string> GetRandomName();
    }
}