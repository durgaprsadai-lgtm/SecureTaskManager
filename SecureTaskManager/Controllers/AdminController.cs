using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureTaskManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        [HttpGet("secret")]
        public IActionResult GetSecret() => Ok("This is an Admin-only secret!");
    }
}
