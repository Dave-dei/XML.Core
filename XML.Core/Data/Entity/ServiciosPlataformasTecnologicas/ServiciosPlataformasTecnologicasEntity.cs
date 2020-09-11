using XML.Core.Funcionalidad;

using System.Xml.Linq;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct ServiciosPlataformasTecnologicasEntity
    {
        public string Version { get; set; }
        public string Periocidad { get; set; }
        public string NumeroServicio { get; set; }
        public string MontoTotalServiciosinIVA { get; set; }
        public string TotalIVATrasladado { get; set; }
        public string TotalIVARetenido { get; set; }
        public string TotalISRRetenido { get; set; }
        public string DifIVAEntregadoPrestServ { get; set; }
        public string MonTotalporUsoPlataforma { get; set; }
        public string MonTotalContribucionGubernamental { get; set; }

        public ServiciosPlataformasTecnologicasEntity(XElement PlataformasTecnologicas)
        {
            Version = BuscarValueXML.Buscar(PlataformasTecnologicas, "Version");
            Periocidad = BuscarValueXML.Buscar(PlataformasTecnologicas, "Periodicidad");
            NumeroServicio = BuscarValueXML.Buscar(PlataformasTecnologicas, "NumServ");
            MontoTotalServiciosinIVA = BuscarValueXML.Buscar(PlataformasTecnologicas, "MonTotServSIVA");
            TotalIVATrasladado = BuscarValueXML.Buscar(PlataformasTecnologicas, "TotalIVATrasladado");
            TotalIVARetenido = BuscarValueXML.Buscar(PlataformasTecnologicas, "TotalIVARetenido");
            TotalISRRetenido = BuscarValueXML.Buscar(PlataformasTecnologicas, "TotalISRRetenido");
            DifIVAEntregadoPrestServ = BuscarValueXML.Buscar(PlataformasTecnologicas, "DifIVAEntregadoPrestServ");
            MonTotalporUsoPlataforma = BuscarValueXML.Buscar(PlataformasTecnologicas, "MonTotalporUsoPlataforma");
            MonTotalContribucionGubernamental = BuscarValueXML.Buscar(PlataformasTecnologicas, "MonTotalContribucionGubernamental");

        }
    }
}
