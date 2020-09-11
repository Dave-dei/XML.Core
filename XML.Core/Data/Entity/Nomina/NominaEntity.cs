using XML.Core.Funcionalidad;
using XML.Core.Funcionalidad.xml;
using System.Xml.Linq;

namespace XML.Core.Data.Entity.Nomina
{
    public struct NominaEntity
    {
        public string FechaPago { get; set; }
        public string FechaInicialPago { get; set; }
        public string FechaFinalPago { get; set; }
        public string NumDiasPagados { get; set; }
        public string TotalPercepciones { get; set; }
        public string TotalDeducciones { get; set; }
        public EmisorEntity Emisor { get; set; }
        public ReceptorEntity Receptor { get; set; }


        public NominaEntity(XElement Nomina)
        {
            FechaPago = BuscarValueXML.Buscar(Nomina, "FechaPago");
            FechaInicialPago = BuscarValueXML.Buscar(Nomina, "FechaInicialPago");
            FechaFinalPago = BuscarValueXML.Buscar(Nomina, "FechaFinalPago");
            NumDiasPagados = BuscarValueXML.Buscar(Nomina, "NumDiasPagados");
            TotalPercepciones = BuscarValueXML.Buscar(Nomina, "TotalPercepciones");
            TotalDeducciones = BuscarValueXML.Buscar(Nomina, "TotalDeducciones");

            Emisor = new EmisorEntity(ValidarElementosDescendientesXML.ObtenerEntity(Nomina, "Emisor"));
            Receptor = new ReceptorEntity(ValidarElementosDescendientesXML.ObtenerEntity(Nomina, "Receptor"));

        }
    }
}
