using Framework.Interfaz;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad.xml;

using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct CargarImpuestosRetenidosNodo : IEjecutarProcessAsync<XMLNodoEntity>
    {
        private XElement Impuestos;
        private XMLNodoEntity XmlNodo;
        private const string Nodo = "RETENCION";
         
        public CargarImpuestosRetenidosNodo(XElement Impuestos)
        {
            this.Impuestos = Impuestos;
            XmlNodo = new XMLNodoEntity();
        }
        public XMLNodoEntity IniciarAsync()
        {
            if (Impuestos != null)
            {
                XmlNodo.Retencion = ValidarElementosDescendientesXML.ObtenerEntity(Impuestos, Nodo);
                XmlNodo.Impuestos = Impuestos;
            }

            return XmlNodo;
        }
    }
}
