
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad;

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct ImpuestosRetenidosEntity
    {
        public bool existeNodo { get; set; }
        public string MontoTotalOperacion { get; set; }
        public string MontoTotalGravado { get; set; }
        public string MontoTotalExento { get; set; }
        public string MontoTotalRetenido { get; set; }
        public List<ImportesRetenidosEntity> Importes { get; set; }

        public ImpuestosRetenidosEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.TotalSPT);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.TotalSPT);

            MontoTotalOperacion = BuscarValueXML.Buscar(nodo?.Totales, "montoTotOperacion");
            MontoTotalGravado = BuscarValueXML.Buscar(nodo?.Totales, "montoTotGrav");
            MontoTotalExento = BuscarValueXML.Buscar(nodo?.Totales, "montoTotExent");
            MontoTotalRetenido = BuscarValueXML.Buscar(nodo?.Totales, "montoTotRet");

            Importes = new List<ImportesRetenidosEntity>();
            if (nodo?.ImportesRetenidos.Any() == true)
                Importes.AddRange(from XElement item in nodo.ImportesRetenidos select new ImportesRetenidosEntity(item));
            
        }
    }
}
