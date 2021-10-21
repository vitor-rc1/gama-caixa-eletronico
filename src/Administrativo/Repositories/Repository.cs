using Administrativo.Entities;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.Repositories
{
    class Repository : IRepository<Saque>
    {
        private List<Saque> saques;

        public List<Saque> Extrato(Guid Id)
        {
            return saques;
        }

        public Saque Sacar(Saque saque)
        {
            saques.Add(saque);
            return saque;
        }
    }
}
