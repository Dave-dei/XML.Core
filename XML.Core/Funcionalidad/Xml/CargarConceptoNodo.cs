
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarConceptoNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "CONCEPTOS";

        public CargarConceptoNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Concepto };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Concepto = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            return XmlNodo;
        }
    }
}
