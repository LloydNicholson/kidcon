namespace KidCon.WebApp.Services;

using System.Threading.Tasks;

public interface IEquationService
{
    Task<string> GetRandomName();
}