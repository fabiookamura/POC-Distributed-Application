using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Domain.Event
{
    public class SqlInsertedEvent
    {
        public int UserId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
