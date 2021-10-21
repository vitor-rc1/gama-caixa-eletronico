using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administrativo.Entities;
using Xunit;

namespace CaixaEletronicoTests
{
    public class AdministrativoEntitiesSaqueTest
    {
        [Fact]
        public void DadoUmSaqueValidoRetornaMensagemComDados()
        {
            // Arrange
            var mensagemEsperada = "Valor: R$300 Data da Retirada: ";

            // Act
            
            var saque = new Saque() {Valor = 300 };

            // Assert
            mensagemEsperada += saque.CreatedAt;
            Assert.Equal(mensagemEsperada, saque.ToString());

        }
    }
}
