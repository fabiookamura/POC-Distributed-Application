using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.UserDelete
{
    public class DeleteUserCommandResponse
    {
        public bool Success { get; set; }

        public DeleteUserCommandResponse(bool success)
        {
            Success = success;
        }
    }
}
