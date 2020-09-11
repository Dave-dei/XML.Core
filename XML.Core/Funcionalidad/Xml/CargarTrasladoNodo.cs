
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarTrasladoNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string NodoImpuesto = "IMPUESTOS";

        public CargarTrasladoNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Traslado };
        }


        public XMLNodoEntity IniciarAsync()
        {

            XmlNodo.Impuestos = ValidarElementosDescendientesXML.ObtenerEntity(xml, NodoImpuesto);

            if (XmlNodo.Impuestos == null) return XmlNodo;

            XmlNodo.Traslado = ValidarElementosDescendientesXML.ObtenerEntity(XmlNodo.Impuestos, "TRASLADO");
            XmlNodo.Retencion = ValidarElementosDescendientesXML.ObtenerEntity(XmlNodo.Impuestos, "RETENCION");

            return XmlNodo;
        }
    }
}
