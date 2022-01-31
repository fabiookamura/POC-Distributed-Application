using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.MongoInsert
{
    public class InsertUserReadOnlyCommandRequest : IRequest<InsertUserReadOnlyCommandResponse>
    {
    }
}
