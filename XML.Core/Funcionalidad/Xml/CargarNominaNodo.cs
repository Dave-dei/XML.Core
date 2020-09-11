using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public class CargarNominaNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "COMPLEMENTO", NodoNomina = "NOMINA";

        public CargarNominaNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.Nomina };
        }
        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.Complemento = ValidarElementosDescendientesXML.ObtenerEntity(xml, Nodo);
            if (XmlNodo.Complemento == null) return XmlNodo;

            XmlNodo.Nomina = ValidarElementosDescendientesXML.ObtenerEntity(XmlNodo.Complemento, NodoNomina);
            if (XmlNodo.Nomina == null) return XmlNodo;

            XmlNodo.Percepcion = ValidarElementosDescendientesXML.ObtenerEntity(XmlNodo.Complemento, "PERCEPCIONES");
            XmlNodo.Deducciones = ValidarElementosDescendientesXML.ObtenerEntity(XmlNodo.Complemento, "DEDUCCIONES");

            return XmlNodo;
        }
    }
}
