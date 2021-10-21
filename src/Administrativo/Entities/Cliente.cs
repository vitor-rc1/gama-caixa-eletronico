using Shared.Entities;
using Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.Entities
{
    class Cliente : Entity
    {
        public string Nome { get; set; }
        public CPF cpf { get; set; }
    }
}
