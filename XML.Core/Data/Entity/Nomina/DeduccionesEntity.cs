using System.Xml.Linq;
using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.Nomina
{
    public struct DeduccionesEntity
    {
        public string Importe { get; set; }
        public string Concepto { get; set; }
        public string TotalOtrasDeducciones { get; set; }
        public string TotalImpuestosRetenidos { get; set; }

        public DeduccionesEntity(XElement Deducciones, XElement Detalle)
        {
            TotalOtrasDeducciones = BuscarValueXML.Buscar(Deducciones, "TotalOtrasDeducciones");
            TotalImpuestosRetenidos = BuscarValueXML.Buscar(Deducciones, "TotalImpuestosRetenidos");

            Importe = BuscarValueXML.Buscar(Detalle, "Importe");
            Concepto = BuscarValueXML.Buscar(Detalle, "Concepto");
        }
    }
}
