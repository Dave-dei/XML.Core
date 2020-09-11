
using XML.Core.Data.Entity.xml;
using System.Collections.Generic;
using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct PeriodoEntity
    {
        public bool existeNodo { get; set; }
        public string MesInicial { get; set; }
        public string MesFin { get; set; }
        public string Ejercicio { get; set; }

        public PeriodoEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.Periodo);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.Periodo);

            MesInicial = BuscarValueXML.Buscar(nodo?.Periodo, "MesIni");
            MesFin = BuscarValueXML.Buscar(nodo?.Periodo, "MesFin");
            Ejercicio = BuscarValueXML.Buscar(nodo?.Periodo, "Ejerc");
        }
    }
}
