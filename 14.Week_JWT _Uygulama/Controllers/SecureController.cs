using Microsoft.AspNetCore.Mvc;

namespace _14.Week_JWT__Uygulama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [HttpGet("secure-data")]
        public IActionResult GetSecureData()
        {
            return Ok("Bu veriye yalnızca yetkilendirilmiş kullanıcılar erişebilir.");
        }
    }
}
