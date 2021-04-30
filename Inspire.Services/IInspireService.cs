using System.Threading.Tasks;

namespace Inspire.Services
{
    public interface IInspireService
    {
        Task<string> GetInspirationalQuote();
    }
}