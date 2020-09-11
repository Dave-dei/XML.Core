using XML.Core.Data.Model;
using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct ComisiondelServicioEntity
    {
        public string Base { get; set; }
        public string Porcentaje { get; set; }
        public string Importe { get; set; }

        public ComisiondelServicioEntity(DetalleServicioSPTModel nodo)
        {
            Base = BuscarValueXML.Buscar(nodo.ComisionDelServicio, "Base");
            Porcentaje = BuscarValueXML.Buscar(nodo.ComisionDelServicio, "Porcentaje");
            Importe = BuscarValueXML.Buscar(nodo.ComisionDelServicio, "Importe");
        }
    }
}
