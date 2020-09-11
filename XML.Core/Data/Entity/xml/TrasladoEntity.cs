
using XML.Core.Data.Entity.xml;
using System.Collections.Generic;
using XML.Core.Funcionalidad;

namespace XML.Core.Entity.xml
{
    public struct TrasladoEntity
    {
        public bool existeNodo { get; set; }
        //Retencion
        public string TotalImpuestosRetenidos { get; set; }
        public string ImpuestoRetencion { get; set; }
        public string ImporteRetencion { get; set; }

        //Traslado
        public string TotalImpuestosTrasladados { get; set; }
        private string TasaOCuota { get; set; }
        public string Tasa { get; set; }
        public string ImporteTraslado { get; }
        public string ImpuestoTraslado { get; set; }

        public TrasladoEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.Traslado);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.Traslado);

            Tasa = string.Empty;
            TasaOCuota = BuscarValueXML.Buscar(nodo?.Traslado, "tasaocuota");

            if (string.IsNullOrWhiteSpace(TasaOCuota))
                Tasa = BuscarValueXML.Buscar(nodo?.Traslado, "tasa");

            TotalImpuestosTrasladados = BuscarValueXML.Buscar(nodo?.Impuestos, "totalimpuestostrasladados");
            ImpuestoTraslado = BuscarValueXML.Buscar(nodo?.Traslado, "impuesto");
            ImporteTraslado = BuscarValueXML.Buscar(nodo?.Traslado, "importe");

            TotalImpuestosRetenidos = BuscarValueXML.Buscar(nodo?.Impuestos, "totalimpuestosretenidos");
            ImpuestoRetencion = BuscarValueXML.Buscar(nodo?.Retencion, "impuesto");
            ImporteRetencion = BuscarValueXML.Buscar(nodo?.Retencion, "importe");
        }
    }
}
