using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetBank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    public abstract class BaseController : ControllerBase
    {

    }
}
