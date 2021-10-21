using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        public TEntity Sacar(TEntity entity);

        public List<TEntity> Extrato(Guid Id);
    }
}
