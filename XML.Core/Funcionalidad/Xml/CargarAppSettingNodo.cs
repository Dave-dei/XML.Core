using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarAppSettingNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "appSettings";


        public CargarAppSettingNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Config };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.appSettings = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            XmlNodo.connectionStrings = ValidarElementosDescendientesXML.ObtenerEntity(xml, "connectionStrings");

            return XmlNodo;

        }
    }
}

