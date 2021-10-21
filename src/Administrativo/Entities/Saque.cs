using Administrativo.ValueObjects;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.Entities
{
    public class Saque : Entity
    {
        public int Valor { get; set; }
        public Cliente Cliente { get; set; }
        public Notas Notas { get; set; }

        public override string ToString()
        {
            return $"Valor: R${Valor} Data da Retirada: {CreatedAt}";
        }
    }
}
