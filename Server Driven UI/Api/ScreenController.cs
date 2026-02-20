using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server_Driven_UI.Application.Features.Login.Interfaces;

namespace Server_Driven_UI.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreenController : ControllerBase
    {
        private readonly ILoginScreenService _loginScreenService;

        public ScreenController(ILoginScreenService loginScreenService) {
            _loginScreenService = loginScreenService;
        }
        [HttpGet("Login")]
        public IActionResult GetLoginScreen() {
            var screen = _loginScreenService.GetLoginScreen();
            return Ok(screen);
        }

    }
}
