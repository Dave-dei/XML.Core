using Framework.Interfaz;

using System.Xml.Linq;

using XML.Core.Data.Entity.xml;

namespace XML.Core.Funcionalidad.xml
{
    public class CargarXSDNodo : IEjecutarProcessAsync<XMLNodoEntity>

    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;

        public CargarXSDNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.xsd };
        }

        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.NodoRaiz = BuscarElementosXML.Buscar(xml);
            return XmlNodo;
        }
    }
}
