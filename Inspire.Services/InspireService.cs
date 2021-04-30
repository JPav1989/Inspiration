using System.Threading.Tasks;

namespace Inspire.Services
{
    internal class InspireService : IInspireService
    {
        public async Task<string> GetInspirationalQuote()
        {
            return "You are awesome!";
        }
    }
}