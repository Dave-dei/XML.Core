using XML.Core.Data.Model;
using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct ContribucionGubernamentalEntity
    {
        public string ImpContrib { get; set; }
        public string EntidadDondePagaLaContribucion { get; set; }

        public ContribucionGubernamentalEntity(DetalleServicioSPTModel nodo)
        {
            ImpContrib = BuscarValueXML.Buscar(nodo.ContribucionGubernamental, "ImpContrib");
            EntidadDondePagaLaContribucion = BuscarValueXML.Buscar(nodo.ContribucionGubernamental, "EntidadDondePagaLaContribucion");
        }
    }
}
