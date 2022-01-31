using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.UserDelete
{
    public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
    {
        public int UserId { get; set; }

        public DeleteUserCommandRequest(int userId)
        {
            UserId = userId;
        }
    }
}
