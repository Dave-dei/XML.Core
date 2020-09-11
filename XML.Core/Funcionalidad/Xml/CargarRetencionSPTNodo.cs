
using Framework.Interfaz;
using XML.Core.Data.Entity.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarRetencionSPTNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XDocument xml;
        private XMLNodoEntity XmlNodo;

        public CargarRetencionSPTNodo(XDocument xml)
        {
            this.xml = xml;
            XmlNodo = new XMLNodoEntity { TipoNodo = Sistema.Nodo.RetencionesSPT };
        }
        public XMLNodoEntity IniciarAsync()
        {
            XmlNodo.NodoRaiz = xml?.Element(xml.Root.Name);
            return XmlNodo;
        }
    }
}
