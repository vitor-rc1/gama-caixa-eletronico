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
    public class GetSaquesByClientIdHandler : QueryHandler<List<Saque>, GetSaquesByClientIdRequest>
    {
        private IRepository<Saque> _repository;

        public GetSaquesByClientIdHandler(IRepository<Saque> repository)
        {
            _repository = repository;
        }

        public override List<Saque> Handle(GetSaquesByClientIdRequest request)
        {
            return _repository.Extrato(request.Id);
        }
    }
}
