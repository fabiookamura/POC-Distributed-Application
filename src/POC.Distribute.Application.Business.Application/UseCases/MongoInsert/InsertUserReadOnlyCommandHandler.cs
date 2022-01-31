using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.UseCases.MongoInsert
{
    public class InsertUserReadOnlyCommandHandler : IRequestHandler<InsertUserReadOnlyCommandRequest, InsertUserReadOnlyCommandResponse>
    {
        public Task<InsertUserReadOnlyCommandResponse> Handle(InsertUserReadOnlyCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
