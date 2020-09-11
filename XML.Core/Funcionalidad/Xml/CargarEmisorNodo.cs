
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarEmisorNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "EMISOR";

        public CargarEmisorNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Emisor };
        }


        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Emisor = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            return XmlNodo;
        }
    }
}
