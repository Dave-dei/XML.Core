using System;

namespace XML.Core.Funcionalidad
{
    public struct ValidarItemXML
    {
        public static bool Validar(string nombre, string Nodo) => string.Equals(nombre?.ToUpper(), Nodo?.ToUpper(), StringComparison.InvariantCultureIgnoreCase);

    }
}
