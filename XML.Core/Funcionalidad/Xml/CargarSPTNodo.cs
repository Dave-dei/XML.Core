
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarSPTNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "ServiciosPlataformasTecnologicas";

        public CargarSPTNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.ServiciosPlataformasTecnologicas };
        }


        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.PlataformasTecnologicas = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            XmlNodo.Servicios = ValidarElementosDescendientesXML.ObtenerEntity(XmlNodo.PlataformasTecnologicas, "Servicios");
            return XmlNodo;

        }
    }
}
