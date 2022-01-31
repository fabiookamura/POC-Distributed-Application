using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.UserUpdate
{
    public class UpdateUserCommandResponse
    {
        public UpdateUserCommandResponse(bool success)
        {
            Success = success;
        }

        public bool Success { get; set; }
    }
}
