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
            var cliente = new Cliente() { Nome = "Josivaldo" };
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
                        var request = new SetSaqueRequest() { Saque = new Saque() { Valor = valor, Notas = separacao.Notas, Cliente = cliente } };
                        handler.Handle(request);

                        Console.Clear();
                        Console.WriteLine("Sua notas são:");
                        foreach (var nota in separacao.Notas.NotasCadastradas)
                        {
                            Console.WriteLine(nota.ToString());

                        }
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido.");
                    }
                } else if (opcao == 2)
                {
                    var handler = new GetSaquesByClientIdHandler(repo);
                    var request = new GetSaquesByClientIdRequest() {Id = cliente.Id };
                    var response = handler.Handle(request);
                    Console.Clear();
                    Console.WriteLine("Extrato bancario:");

                    foreach (var saque in response)
                    {
                        Console.WriteLine(saque.ToString());

                    }
                }
                Console.ReadLine();

            }
        }
    }
}
