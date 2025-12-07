using MiAplicacion;
using Xunit;

public class ValidadorDeContrasenasTests
{
    private readonly ValidadorDeContrasenas _validador = new();

    [Theory]
    [InlineData("Abc12345", true)]       // Cumple todas las reglas
    [InlineData("abc12345", false)]      // Falta mayúscula
    [InlineData("ABC12345", false)]      // Falta minúscula
    [InlineData("Abcdefgh", false)]      // Falta número
    [InlineData("Abc12", false)]         // Muy corta
    [InlineData("", false)]              // Vacía
    public void EsValida_PruebasVariadas(string contrasena, bool esperado)
    {
        bool resultado = _validador.EsValida(contrasena);
        Assert.Equal(esperado, resultado);
    }
}