using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XML.Core.Data.Model;
using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct DetallesServicioEntity
    {
        public string FormaPagoServ { get; set; }
        public string TipoDeServ { get; set; }
        public string SubTipServ { get; set; }
        public string RFCTerceroAutorizado { get; set; }
        public string FechaServ { get; set; }
        public string PrecioServSinIVA { get; set; }
        public List<ImpuestosTrasladadosServicioEntity> ImpuestosTrasladoServicio { get; set; }
        public ContribucionGubernamentalEntity Contribucion { get; set; }
        public ComisiondelServicioEntity ComisionServicio { get; set; }

        public DetallesServicioEntity(DetalleServicioSPTModel servicio)
        {
            FormaPagoServ = BuscarValueXML.Buscar(servicio.DetallesDelServicio, "FormaPagoServ");
            TipoDeServ = BuscarValueXML.Buscar(servicio.DetallesDelServicio, "TipoDeServ");
            SubTipServ = BuscarValueXML.Buscar(servicio.DetallesDelServicio, "SubTipServ");
            RFCTerceroAutorizado = BuscarValueXML.Buscar(servicio.DetallesDelServicio, "RFCTerceroAutorizado");
            FechaServ = BuscarValueXML.Buscar(servicio.DetallesDelServicio, "FechaServ");
            PrecioServSinIVA = BuscarValueXML.Buscar(servicio.DetallesDelServicio, "PrecioServSinIVA");

            ImpuestosTrasladoServicio = new List<ImpuestosTrasladadosServicioEntity>();

            if (servicio.ImpuestosTrasladadosdelServicio.Any())
            {
                ImpuestosTrasladoServicio.AddRange(from XElement item in servicio.ImpuestosTrasladadosdelServicio
                                                   select new ImpuestosTrasladadosServicioEntity(item));
            }

            Contribucion = new ContribucionGubernamentalEntity(servicio);
            ComisionServicio = new ComisiondelServicioEntity(servicio);
        }





    }
}
