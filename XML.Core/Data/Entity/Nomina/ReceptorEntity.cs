using XML.Core.Funcionalidad;

using System.Xml.Linq;

namespace XML.Core.Data.Entity.Nomina
{
    public struct ReceptorEntity
    {
        public string CURP { get; set; }
        public string NumSeguridadSocial { get; set; }
        public string FechaInicioRelLaboral { get; set; }
        public string Antiguedad { get; set; }
        public string TipoContrato { get; set; }
        public string Sindicalizado { get; set; }
        public string TipoJornada { get; set; }
        public string TipoRegimen { get; set; }
        public string NumEmpleado { get; set; }
        public string RiesgoPuesto { get; set; }
        public string PeriodicidadPago { get; set; }
        public string CuentaBancaria { get; set; }
        public string SalarioDiarioIntegrado { get; set; }
        public string ClaveEntFed { get; set; }
        

        public ReceptorEntity(XElement Receptor)
        {
            CURP = BuscarValueXML.Buscar(Receptor, "CURP");
            NumSeguridadSocial = BuscarValueXML.Buscar(Receptor, "NumSeguridadSocial");
            FechaInicioRelLaboral = BuscarValueXML.Buscar(Receptor, "FechaInicioRelLaboral");
            Antiguedad = BuscarValueXML.Buscar(Receptor, "Antigüedad");
            TipoContrato = BuscarValueXML.Buscar(Receptor, "TipoContrato");
            Sindicalizado = BuscarValueXML.Buscar(Receptor, "Sindicalizado");
            TipoJornada = BuscarValueXML.Buscar(Receptor, "TipoJornada");
            TipoRegimen = BuscarValueXML.Buscar(Receptor, "TipoRegimen");
            NumEmpleado = BuscarValueXML.Buscar(Receptor, "NumEmpleado");
            RiesgoPuesto = BuscarValueXML.Buscar(Receptor, "RiesgoPuesto");
            PeriodicidadPago = BuscarValueXML.Buscar(Receptor, "PeriodicidadPago");
            CuentaBancaria = BuscarValueXML.Buscar(Receptor, "CuentaBancaria");
            SalarioDiarioIntegrado = BuscarValueXML.Buscar(Receptor, "SalarioDiarioIntegrado");
            ClaveEntFed = BuscarValueXML.Buscar(Receptor, "ClaveEntFed");
        }
    }
}
