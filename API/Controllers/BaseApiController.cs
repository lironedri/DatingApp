using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    // All controllers will inherit from this controller
        public class BaseApiController : ControllerBase
    {
        
    }
}