using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAplicacion
{
    public class Calculadora
    {
        public int Sumar(int a, int b) => a + b;
        public int Restar(int a, int b) => a - b;
        public bool EsPar(int numero) => numero % 2 == 0;
    }
}
