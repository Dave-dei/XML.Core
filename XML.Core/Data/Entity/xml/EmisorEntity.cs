
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad;

using System.Collections.Generic;

namespace XML.Core.Entity.xml
{
    public struct EmisorEntity
    {
        public bool existeNodo { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }

        public EmisorEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.Emisor);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.Emisor);

            RFC = BuscarValueXML.Buscar(nodo?.Emisor, "Rfc");

            if (string.IsNullOrWhiteSpace(RFC))
                RFC = BuscarValueXML.Buscar(nodo?.Emisor, "RFCEmisor");

            Nombre = BuscarValueXML.Buscar(nodo?.Emisor, "Nombre");

            if (string.IsNullOrWhiteSpace(Nombre))
                Nombre = BuscarValueXML.Buscar(nodo?.Emisor, "NomDenRazSocE");
        }
    }
}
