using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC.Distribute.Application.Business.Application.UseCases.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Presentation.Api.UseCases.User.UserInsert
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string nome, string email)
        {
            var userRequest = new InsertUserCommandRequest(nome, email);
            await _mediator.Send(userRequest);
            return new OkObjectResult(HttpStatusCode.OK);
        }
    }
}
