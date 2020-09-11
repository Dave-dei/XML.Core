using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.xml
{
    public struct ValidarElementosDescendientesXML
    {
        public static List<XElement> ObtenerLista(XElement xml, string Nodo) => xml?.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, Nodo)).ToList() ?? new List<XElement>();
        public static List<XElement> ObtenerLista(XDocument xml, string Nodo) => xml?.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, Nodo)).ToList() ?? new List<XElement>();
      
        public static XElement ObtenerEntity(XDocument xml, string Nodo) => xml?.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, Nodo)).FirstOrDefault();
        public static XElement ObtenerEntity(XElement xml, string Nodo) => xml?.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, Nodo)).FirstOrDefault();

    }
}
