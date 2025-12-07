using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAplicacion.Tests
{
    internal class CalculadoraTests
    {

        [Fact]
        public void Sumar_DosNumeros_RetornaResultadoCorrecto()
        {
            var calc = new Calculadora();
            var resultado = calc.Sumar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Restar_DosNumeros_RetornaResultadoCorrecto()
        {
            var calc = new Calculadora();
            var resultado = calc.Restar(10, 4);
            Assert.Equal(6, resultado);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(10, true)]
        public void EsPar_ValidaNumeros(int numero, bool esperado)
        {
            var calc = new Calculadora();
            var resultado = calc.EsPar(numero);
            Assert.Equal(esperado, resultado);
        }
    }
}
