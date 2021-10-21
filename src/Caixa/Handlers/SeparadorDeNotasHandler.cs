using Administrativo.ValueObjects;
using Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.Handlers
{
    class SeparadorDeNotasHandler
    {
        public int Restante { get; private set; }
        public Notas Notas { get; set; }
        public bool SeparacaoComSucesso { get; set; }




        public SeparadorDeNotasHandler(int valor)
        {
            Restante = valor;
            var notas = new Notas();

            foreach (Nota nota in notas.NotasCadastradas)
            {
                if (Restante >= nota.Valor)
                {
                    var quantidadeNotas = Restante / nota.Valor;
                    nota.Quantidade = quantidadeNotas;

                    Restante -= quantidadeNotas * nota.Valor;
                }

                if (Restante == 0)
                {
                    SeparacaoComSucesso = true;
                    break;
                }
            }

            Notas = notas;

        }


    }
}
