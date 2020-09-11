using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.xml
{
    public static class BuscarElementosXML
    {
        public static List<XElement> Buscar(List<XElement> elemento, string LocalName)
        {
            if (elemento?.Elements().Any() == true)
                return elemento.Elements().Where(i => ValidarItemXML.Validar(i.Name.LocalName, LocalName)).ToList();

            return new List<XElement>();

        }
        public static XElement Buscar(XDocument xsd)
        {
            var ns = xsd.Root.GetDefaultNamespace();
            var prefix = xsd.Root.GetNamespaceOfPrefix("xs");

            return xsd.Root.Element(prefix + "element");

        }

    }
}
