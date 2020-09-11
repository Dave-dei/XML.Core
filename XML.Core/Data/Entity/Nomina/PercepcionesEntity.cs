using System.Xml.Linq;
using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.Nomina
{
    public struct PercepcionesEntity
    {
        public string TotalSueldos { get; set; }
        public string TotalGravado { get; set; }
        public string TotalExento { get; set; }
        public string ImporteGravado { get; set; }
        public string Concepto { get; set; }
        public string ImporteExento { get; set; }

        public PercepcionesEntity(XElement Percepcion, XElement Detalle)
        {
            TotalGravado = BuscarValueXML.Buscar(Percepcion, "TotalGravado");
            TotalExento = BuscarValueXML.Buscar(Percepcion, "TotalExento");
            TotalSueldos = BuscarValueXML.Buscar(Percepcion, "TotalSueldos");
            Concepto = BuscarValueXML.Buscar(Detalle, "Concepto");
            ImporteGravado = BuscarValueXML.Buscar(Detalle, "ImporteGravado");
            ImporteExento = BuscarValueXML.Buscar(Detalle, "ImporteExento");
        }
    }
}
