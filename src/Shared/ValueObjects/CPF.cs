using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ValueObjects
{
    public class CPF
    {
        public string Valor { get; private set; }

        public CPF (string cpf)
        {
            Valor = cpf;
        }
    }
}
