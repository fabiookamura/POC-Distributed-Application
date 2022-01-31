using MediatR;
using POC.Distribute.Application.Business.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.User
{
    public class InsertUserCommandHandler : IRequestHandler<InsertUserCommandRequest, InsertUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;

        public InsertUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<InsertUserCommandResponse> Handle(InsertUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = new POC.Distribute.Application.Business.Domain.Entities.User(0, request.Nome, request.Email);
            var result = await _userRepository.InsertUserAsync(user);

            return new InsertUserCommandResponse(result);

        }
    }
}
