using Administrativo.Entities;
using Administrativo.Queries;
using Administrativo.Repositories;
using Administrativo.Requests;
using Caixa.Handlers;
using System;

namespace Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            //var repo = new Repository();
            //var handler = new SetSaqueHandler(repo);

            //var request = new SetSaqueRequest() { Saque = new Saque() { Valor = 200 } };

            //var response = handler.Handle(request);

            //Console.WriteLine(response.Id);

            var notas = new SeparadorDeNotasHandler(321);

            Console.WriteLine(notas.SeparacaoComSucesso);
            foreach (var item in notas.Notas.NotasCadastradas)
            {
                Console.WriteLine(item.Valor + " " + item.Quantidade);
                
            }
        }
    }
}
