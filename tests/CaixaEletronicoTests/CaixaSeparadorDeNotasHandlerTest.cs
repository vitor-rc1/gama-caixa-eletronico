using Administrativo.ValueObjects;
using Newtonsoft.Json;
using Caixa.Handlers;
using System.Linq;
using System;
using Xunit;

namespace CaixaEletronicoTests
{
    public class CaixaSeparadorDeNotasHandlerTest
    {
        [Fact]
        public void DadoUmValorValidoSacaComSucesso()
        {
            // Arrange
            int valor = 320;
            var notas = new Notas();
            notas.NotasCadastradas.SingleOrDefault(nota => nota.Valor == 100).Quantidade = 3;
            notas.NotasCadastradas.SingleOrDefault(nota => nota.Valor == 20).Quantidade = 1;
            // Act
            var separacao = new SeparadorDeNotasHandler(valor);

            // Assert
            Assert.True(separacao.SeparacaoComSucesso);

            var notasResponse = JsonConvert.SerializeObject(separacao.Notas);
            var notasEsperadas = JsonConvert.SerializeObject(notas);

            Assert.Equal(notasEsperadas, notasResponse);
        }

        [Fact]
        public void DadoUmValorInvalidoRetornaErro()
        {
            // Arrange
            int valor = 321;

            // Act
            var separacao = new SeparadorDeNotasHandler(valor);

            // Assert
            Assert.False(separacao.SeparacaoComSucesso);

        }
    }
}
