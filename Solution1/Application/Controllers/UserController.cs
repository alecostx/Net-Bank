using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetBank.Domain.Interfaces.Service;
using NetBank.Domain.Models.Requests;
using NetBank.Domain.Models.Responses;

namespace NetBank.API.Controllers
{
    /// <summary>
    /// Api de usuarios
    /// </summary>
    public class UserController : BaseController
    {
        private readonly IUserService _userservice;
        public UserController(IUserService userService)
        {
            _userservice = userService;
        }
        /// <summary>
        /// Lista todos os usuários na base
        /// </summary>
        /// <param name="request">Objeto request para consultar usuarios</param>
        /// <returns>Objeto response com a lista de usuarios</returns>
        [HttpGet("user")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserResponse>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationProblemDetails))]
        public async Task<ActionResult> GetUsersAsync([FromQuery] GetUserRequest request)
        {
            return Ok(await _userservice.GetUsersAsync(request));
        }
    }
}
