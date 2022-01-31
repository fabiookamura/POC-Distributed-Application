using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.User
{
    public class InsertUserCommandResponse 
    {
        public InsertUserCommandResponse(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; set; }
    }
}
