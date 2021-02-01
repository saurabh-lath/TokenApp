using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TokenApp.TokenApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly ILogger<TokenController> _logger;

        public TokenController(ILogger<TokenController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("validate")]
        public ApiData ValidateToken()
        {
            return new ApiData() { AppUrl = "test" };
        }

        [HttpPost]
        [Route("generate")]
        public ApiData GenerateToken()
        {
            return new ApiData() { AppUrl = "test" };
        }
    }
}
