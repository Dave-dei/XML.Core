using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarNugetNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "packages";


        public CargarNugetNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Nuget };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Nugets = ValidarElementosDescendientesXML.ObtenerLista(xml, Nodo);
            return XmlNodo;

        }
    }
}

