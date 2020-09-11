using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarVisualStudioNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "PropertyGroup";


        public CargarVisualStudioNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.VisualStudio };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.PropertyGroup = ValidarElementosDescendientesXML.ObtenerLista(xml, Nodo);
            XmlNodo.ItemGroup = ValidarElementosDescendientesXML.ObtenerLista(xml, "ItemGroup");

            return XmlNodo;

        }
    }
}

