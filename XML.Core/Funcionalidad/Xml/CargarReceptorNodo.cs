
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarReceptorNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "RECEPTOR";

        public CargarReceptorNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Receptor };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Receptor = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            XmlNodo.Nacional = ValidarElementosDescendientesXML.ObtenerEntity(XmlNodo.Receptor, "Nacional");
            return XmlNodo;
        }
    }
}
