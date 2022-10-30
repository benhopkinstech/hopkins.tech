using hopkins.tech.Server.Data;
using hopkins.tech.Shared;
using Microsoft.AspNetCore.Mvc;

namespace hopkins.tech.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ResponseCache(Duration = 120)]
    public class SocialIconController : ControllerBase
    {
        private readonly HopkinsTechContext _context;
        public SocialIconController(HopkinsTechContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<SocialIcon> GetSocialIcons()
        {
            return _context.SocialIcons;
        }
    }
}
