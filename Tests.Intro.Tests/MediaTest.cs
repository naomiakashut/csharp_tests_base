using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class MediaTest
    {   //Média com dois parâmetros
        //Testes (2)
        [Theory]
        [InlineData(2, 2, "2,0")]
        [InlineData(2, 4, "3,0")]
        [InlineData(2.5, 5.2, "3,9")]
        public void Quando_PassadoValorValido_Deve_RetornarMediaDois(double entrada1, double entrada2, string esperado)
        {
            var retorno = Media.Simples(entrada1, entrada2);

            Assert.Equal(retorno, esperado);
        }
        //Zero (2)
        [Fact]
        public void Quando_PassadoZero_Deve_RetornarZeroDois()
        {
            var entrada1 = 0;
            var entrada2 = 0;
            var esperado = "0";

            var retorno = Media.Simples(entrada1, entrada2);

            Assert.Equal(retorno, esperado);
        }
        //Exceções (2)
        [Theory]
        [InlineData(2, -2)]
        [InlineData(-2, 4)]
        [InlineData(-2, -4)]
        public void Quando_PassadoValorInvalido_Deve_RetornarExcecaoDois(double entrada1, double entrada2)
        {
            var exception = Assert.Throws<ArgumentException>(
              () => Media.Simples(entrada1, entrada2));

        }

        //Média com três parâmetros
        //Testes (3)
        [Theory]
        [InlineData(5, 6, 7, "6,0")]
        [InlineData(5, 10, 10, "8,3")]
        [InlineData(10.5, 6.2, 7.8, "8,2")]
        public void Quando_PassadoValorValido_Deve_RetornarMediaTres(double entrada1, double entrada2, double entrada3, string esperado)
        {
            var retorno = Media.Simples(entrada1, entrada2, entrada3);

            Assert.Equal(retorno, esperado);
        }
        //Zero (3)
        [Fact]
        public void Quando_PassadoZero_Deve_RetornarZeroTres()
        {
            var entrada1 = 0;
            var entrada2 = 0;
            var entrada3 = 0;
            var esperado = "0";

            var retorno = Media.Simples(entrada1, entrada2, entrada3);

            Assert.Equal(retorno, esperado);
        }
        //Exceções (3)
        [Theory]
        [InlineData(-2, 2, 1)]
        [InlineData(2, -4, 1)]
        [InlineData(2, 4, -1)]
        [InlineData(-2, -4, 1)]
        [InlineData(2, -4, -1)]
        [InlineData(-2, 4, -1)]
        [InlineData(-2, -4, -1)]
        public void Quando_PassadoValorInvalido_Deve_RetornarExcecaoTres(double entrada1, double entrada2, double entrada3)
        {
            var exception = Assert.Throws<ArgumentException>(
              () => Media.Simples(entrada1, entrada2, entrada3));

        }




    }


}
