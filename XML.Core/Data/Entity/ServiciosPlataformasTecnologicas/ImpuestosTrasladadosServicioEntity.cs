using XML.Core.Funcionalidad;

using System.Xml.Linq;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct ImpuestosTrasladadosServicioEntity
    {
        public string Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public string TasaCuota { get; set; }
        public string Importe { get; set; }

        public ImpuestosTrasladadosServicioEntity(XElement item)
        {
            Base = BuscarValueXML.Buscar(item, "Base");
            Impuesto = BuscarValueXML.Buscar(item, "Impuesto");
            TipoFactor = BuscarValueXML.Buscar(item, "TipoFactor");
            TasaCuota = BuscarValueXML.Buscar(item, "TasaCuota");
            Importe = BuscarValueXML.Buscar(item, "Importe");
           
        }
    }
}
