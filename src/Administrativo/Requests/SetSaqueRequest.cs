using Administrativo.Entities;
using Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.Requests
{
    class SetSaqueRequest : Request
    {
        public Saque Saque { get; set; }
    }
}
