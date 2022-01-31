using MediatR;
using POC.Distribute.Application.Business.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.UserDelete
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = new POC.Distribute.Application.Business.Domain.Entities.User(request.UserId, "", "");
            var result = await _userRepository.DeleteUserAsync(user);

            return new DeleteUserCommandResponse(result);
        }
    }
}
