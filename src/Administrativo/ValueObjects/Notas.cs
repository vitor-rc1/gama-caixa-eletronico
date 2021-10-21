using Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.ValueObjects
{
    public class Notas
    {
        public List<Nota> NotasCadastradas = new List<Nota>();

        public Notas()
        {
            NotasCadastradas.Add(new Nota { Valor = 100 });
            NotasCadastradas.Add(new Nota { Valor = 50 });
            NotasCadastradas.Add(new Nota { Valor = 20 });
            NotasCadastradas.Add(new Nota { Valor = 10 });
            NotasCadastradas.Add(new Nota { Valor = 5 });
        }
    }
}
