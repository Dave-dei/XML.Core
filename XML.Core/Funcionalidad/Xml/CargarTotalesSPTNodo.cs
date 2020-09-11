
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarTotalesSPTNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "Totales";

        public CargarTotalesSPTNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.TotalSPT };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Totales = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            XmlNodo.ImportesRetenidos = ValidarElementosDescendientesXML.ObtenerLista(XmlNodo.Totales, "ImpRetenidos");

            return XmlNodo;
        }
    }
}
