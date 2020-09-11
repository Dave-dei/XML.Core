
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarComprobanteNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "COMPROBANTE";
         
        public CargarComprobanteNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Comprobante };
        }


        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Comprobante = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            return XmlNodo;
        }
    }
}
