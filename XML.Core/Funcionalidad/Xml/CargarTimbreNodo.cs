
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarTimbreNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "TIMBREFISCALDIGITAL";


        public CargarTimbreNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Timbre };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Timbre = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            return XmlNodo;
        }
    }
}
