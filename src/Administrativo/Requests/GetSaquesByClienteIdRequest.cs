using Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.Requests
{
    public class GetSaquesByClienteIdRequest : Request
    {
        public Guid Id { get; set; }
    }
}
