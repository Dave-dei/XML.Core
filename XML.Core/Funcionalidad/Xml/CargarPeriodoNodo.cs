
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;


namespace XML.Core.Funcionalidad
{
    public struct CargarPeriodoNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "Periodo";



        public CargarPeriodoNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Periodo };
        }


        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Periodo = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            return XmlNodo;
        }
    }
}
