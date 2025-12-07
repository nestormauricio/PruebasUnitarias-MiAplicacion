namespace MiAplicacion;

public class ValidadorDeContrasenas
{
    public bool EsValida(string contrasena)
    {
        if (string.IsNullOrWhiteSpace(contrasena))
            return false;

        if (contrasena.Length < 8)
            return false;

        bool tieneMayuscula = contrasena.Any(char.IsUpper);
        bool tieneMinuscula = contrasena.Any(char.IsLower);
        bool tieneNumero = contrasena.Any(char.IsDigit);

        return tieneMayuscula && tieneMinuscula && tieneNumero;
    }
}