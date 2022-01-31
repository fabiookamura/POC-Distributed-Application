using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
