using System.Collections.Generic;
using System.Threading.Tasks;
using Inspire.Services;
using Microsoft.AspNetCore.Mvc;

namespace InspireApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InspireController : ControllerBase
    {
        private readonly IInspireService _inspireService;

        public InspireController(IInspireService inspireService)
        {
            _inspireService = inspireService;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            return await _inspireService.GetInspirationalQuote();
        }
    }
}