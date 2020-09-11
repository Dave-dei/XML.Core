using System.Text.RegularExpressions;

namespace XML.Core.Funcionalidad.Matematica
{
    public struct ValidarExpresionRegular
    {
        public static bool Validar(string expresion, string value) => Regex.IsMatch(value, expresion);
    }
}
