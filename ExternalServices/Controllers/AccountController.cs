using System.Threading.Tasks;

using EnergonSoftware.Services.Data;

using Microsoft.AspNetCore.Mvc;

namespace EnergonSoftware.Services.Controllers
{
    [Route("api/[controller]")]
    public sealed class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST api/account/login
        [HttpPost("login")]
        public async Task<JsonResult> PostLogin([FromBody] string value)
        {
await Task.Delay(0).ConfigureAwait(false);
            return Json(new { success = false });
        }

        // POST api/account/logout
        [HttpPost("logout")]
        public async Task<JsonResult> PostLogout([FromBody] string value)
        {
await Task.Delay(0).ConfigureAwait(false);
            return Json(new { success = true });
        }
    }
}
