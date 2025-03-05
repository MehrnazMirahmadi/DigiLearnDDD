using DigiLearn.Application.Commands.User;
using DigiLearn.Application.DTOs;
using DigiLearn.Application.Queries.User;
using DigiLearn.Shared.Abstraction.Commands;
using DigiLearn.Shared.Abstraction.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DigiLearn.API.Controllers;
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public UserController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersList()
        {
            var result = await _queryDispatcher.FetchAsync(new GetUsersList());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] AddUser command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
