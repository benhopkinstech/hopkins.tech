using hopkins.tech.Server.Data;
using hopkins.tech.Shared;
using Microsoft.AspNetCore.Mvc;

namespace hopkins.tech.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ResponseCache(Duration = 120)]
    public class IndexController : ControllerBase
    {
        private readonly HopkinsTechContext _context;
        public IndexController(HopkinsTechContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IndexData? GetIndexData()
        {
            return _context.Index.FirstOrDefault();
        }
    }
}
