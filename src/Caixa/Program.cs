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
            var repo = new Repository();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Extrato");
                Console.WriteLine("0 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                } else if (opcao == 1)
                {
                    Console.WriteLine("Digite o Valor Desejado");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    var separacao = new SeparadorDeNotasHandler(valor);

                    if (separacao.SeparacaoComSucesso)
                    {
                        var handler = new SetSaqueHandler(repo);
                        var request = new SetSaqueRequest() { Saque = new Saque() { Valor = valor, Notas = separacao.Notas } };
                        var response = handler.Handle(request);
                        Console.Clear();
                        Console.WriteLine("Sua notas são:");
                        foreach (var item in separacao.Notas.NotasCadastradas)
                        {
                            Console.WriteLine(item.Valor + " " + item.Quantidade);

                        }
                        Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                } else if (opcao == 2)
                {

                }
            }
        }
    }
}
