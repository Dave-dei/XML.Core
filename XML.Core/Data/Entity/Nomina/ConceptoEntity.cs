
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad;

using System.Collections.Generic;

namespace XML.Core.Data.Entity.Nomina
{
    public struct ConceptoEntity
    {
        public bool existeNodo { get; }
        public string Cantidad { get; }
        public string ClaveUnidad { get; }
        public string Descripcion { get; }
        public string ValorUnitario { get; }
        public string Importe { get; }
        public string Descuento { get; }
        public string ClaveProductorServicio { get; }

        public ConceptoEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.Concepto);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.Concepto);

            ClaveProductorServicio = BuscarValueXML.Buscar(nodo?.Concepto, "ClaveProdServ", Sistema.Nivel.ElementroAtributo);
            Cantidad = BuscarValueXML.Buscar(nodo?.Concepto, "cantidad", Sistema.Nivel.ElementroAtributo);
            ClaveUnidad = BuscarValueXML.Buscar(nodo?.Concepto, "ClaveUnidad", Sistema.Nivel.ElementroAtributo);
            Descripcion = BuscarValueXML.Buscar(nodo?.Concepto, "descripcion", Sistema.Nivel.ElementroAtributo);
            ValorUnitario = BuscarValueXML.Buscar(nodo?.Concepto, "valorunitario", Sistema.Nivel.ElementroAtributo);
            Importe = BuscarValueXML.Buscar(nodo?.Concepto, "importe", Sistema.Nivel.ElementroAtributo);
            Descuento = BuscarValueXML.Buscar(nodo?.Concepto, "Descuento", Sistema.Nivel.ElementroAtributo);

        }
    }
}
