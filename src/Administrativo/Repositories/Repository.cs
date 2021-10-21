using Administrativo.Entities;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.Repositories
{
    public class Repository : IRepository<Saque>
    {
        private List<Saque> saques = new List<Saque>();

        public List<Saque> Extrato(Guid Id)
        {
            return saques.Where(saque => saque.Cliente.Id == Id).ToList() ;
        }

        public Saque Sacar(Saque saque)
        {
            saques.Add(saque);
            return saque;
        }
    }
}
