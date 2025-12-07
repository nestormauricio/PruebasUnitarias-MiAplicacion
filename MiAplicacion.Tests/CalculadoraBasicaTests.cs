using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiAplicacion;

namespace MiAplicacion.Tests;

public class CalculadoraBasicaTests
{
    [Fact]
    public void Sumar_DosMasTres_RegresaCinco()
    {
        var calc = new CalculadoraBasica();

        int resultado = calc.Sumar(2, 3);

        Assert.Equal(5, resultado);
    }
}