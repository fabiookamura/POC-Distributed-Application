using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC.Distribute.Application.Business.Application.UseCases.UserDelete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Presentation.Api.UseCases.User.UserDelete
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpDelete]
        public async Task<IActionResult> Get(int userId)
        {
            var userRequest = new DeleteUserCommandRequest(userId);
            await _mediator.Send(userRequest);
            return new OkObjectResult(HttpStatusCode.OK);
        }
    }
}
