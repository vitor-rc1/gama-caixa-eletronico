using Administrativo.Entities;
using Administrativo.Requests;
using Shared.Handlers;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.Queries
{
    class SetSaqueHandler : QueryHandler<Saque, SetSaqueRequest>
    {
        private IRepository<Saque> _repository;

        public SetSaqueHandler(IRepository<Saque> repository)
        {
            _repository = repository;
        }

        public override Saque Handle(SetSaqueRequest request)
        {
           return _repository.Sacar(request.Saque);
        }
    }
}
