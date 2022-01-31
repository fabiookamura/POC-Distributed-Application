using MediatR;
using POC.Distribute.Application.Business.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.UserUpdate
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = new POC.Distribute.Application.Business.Domain.Entities.User()
            {
                Email = request.Email,
                Nome = request.Nome,
                UserId = request.UserId
            };
            var result = await _userRepository.UpdateUserAsync(user);

            return new UpdateUserCommandResponse(result);
        }
    }
}
