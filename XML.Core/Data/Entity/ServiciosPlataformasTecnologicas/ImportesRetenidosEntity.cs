using XML.Core.Funcionalidad;
using System.Xml.Linq;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct ImportesRetenidosEntity
    {
        public string BaseRetencion { get; set; }
        public string Impuesto { get; set; }
        public string montoRetenido { get; set; }
        public string TipoPagoRetencion { get; set; }

        public ImportesRetenidosEntity(XElement item)
        {
            BaseRetencion = BuscarValueXML.Buscar(item, "BaseRet");
            Impuesto = BuscarValueXML.Buscar(item, "Impuesto");
            montoRetenido = BuscarValueXML.Buscar(item, "montoRet");
            TipoPagoRetencion = BuscarValueXML.Buscar(item, "TipoPagoRet");
        }
    }
}
