using System;

namespace MiAplicacion
{
    internal class Program
    {
        static void Main()
        {
            var validador = new ValidadorDeContrasenas();

            string prueba = "ABC12345";  // Puedes cambiar la contraseña aquí

            bool resultado = validador.EsValida(prueba);  // <-- Pon el breakpoint aquí

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
