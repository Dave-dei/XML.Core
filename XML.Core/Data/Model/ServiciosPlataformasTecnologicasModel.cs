
using XML.Core.Data.Entity.xml;
using XML.Core.Data.Entity.ServiciosPlataformasTecnologicas;
using XML.Core.Funcionalidad;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace XML.Core.Data.Model
{
    public class ServiciosPlataformasTecnologicasModel : XMLFactoryModel
    { 
        public List<DetallesServicioEntity> ServiciosDetalles;
        public RetencionesSPTEntity Retenciones;
        public ImpuestosRetenidosEntity ImpuestosRetenidos;
        public PeriodoEntity Periodo;
        public ServiciosPlataformasTecnologicasEntity ServiciosPlataformasTecnologicas;

        public ServiciosPlataformasTecnologicasModel(List<XMLNodoEntity> lstNodos) : base(lstNodos)
        {
            try
            {
                XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.ServiciosPlataformasTecnologicas);
                existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.ServiciosPlataformasTecnologicas);

                ServiciosPlataformasTecnologicas = new ServiciosPlataformasTecnologicasEntity(nodo?.PlataformasTecnologicas);
                Retenciones = new RetencionesSPTEntity(lstNodos);
                ImpuestosRetenidos = new ImpuestosRetenidosEntity(lstNodos);
                Periodo = new PeriodoEntity(lstNodos);

                var DetallesDelServicio = nodo?.Servicios.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, "DetallesDelServicio")).ToList();
                ServiciosDetalles = new List<DetallesServicioEntity>();

                if (DetallesDelServicio?.Any() == true)
                {
                    nodo?.lstServicios.AddRange(from XElement item in DetallesDelServicio
                                                select new DetalleServicioSPTModel(
                                                    item,
                                                    item.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, "ImpuestosTrasladadosdelServicio")).ToList(),
                                                    item.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, "ContribucionGubernamental")).FirstOrDefault(),
                                                    item.Descendants().Where(e => ValidarItemXML.Validar(e.Name.LocalName, "ComisionDelServicio")).FirstOrDefault()
                                                ));

                    ServiciosDetalles.AddRange(from DetalleServicioSPTModel item in nodo.lstServicios select new DetallesServicioEntity(item));
                }
            }
            catch (System.Exception ex)
            {
                Error = ex;
            }
        }

        public override XMLFactoryModel Mapear() => this;

    }
}
