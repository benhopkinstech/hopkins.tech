using hopkins.tech.Server.Data;
using hopkins.tech.Shared;
using Microsoft.AspNetCore.Mvc;

namespace hopkins.tech.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ResponseCache(Duration = 120)]
    public class AboutController : ControllerBase
    {
        private readonly HopkinsTechContext _context;
        public AboutController(HopkinsTechContext context)
        {
            _context = context;
        }

        [HttpGet]
        public AboutData? GetAboutData()
        {
            return _context.About.FirstOrDefault();
        }
    }
}
