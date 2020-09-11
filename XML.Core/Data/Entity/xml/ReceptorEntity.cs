
using XML.Core.Data.Entity.xml;
using System.Collections.Generic;
using XML.Core.Funcionalidad;

namespace XML.Core.Entity.xml
{
    public struct ReceptorEntity
    {
        public bool existeNodo { get; set; }
        public string Nacionalidad { get; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string UsoCFDI { get; set; }

        public ReceptorEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.Receptor);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.Receptor);

            Nacionalidad = BuscarValueXML.Buscar(nodo?.Receptor, "Nacionalidad");
            RFC = BuscarValueXML.Buscar(nodo?.Nacional, "RFCRecep");

            if (string.IsNullOrWhiteSpace(RFC))
                RFC = BuscarValueXML.Buscar(nodo?.Receptor, "Rfc");

            Nombre = BuscarValueXML.Buscar(nodo?.Nacional, "NomDenRazSocR");

            if (string.IsNullOrWhiteSpace(Nombre))
                Nombre = BuscarValueXML.Buscar(nodo?.Receptor, "Nombre");

            CURP = BuscarValueXML.Buscar(nodo?.Nacional, "CURPR");
            UsoCFDI = BuscarValueXML.Buscar(nodo?.Receptor, "UsoCFDI");

        }
    }
}
