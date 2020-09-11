
using XML.Core.Data.Entity.xml;
using System.Collections.Generic;
using XML.Core.Funcionalidad;

namespace XML.Core.Entity.xml
{
    public struct TimbreEntity
    {
        public bool existeNodo { get; set; }
        public string uuid { get; set; }
        public string fechatimbrado { get; set; }

        public TimbreEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.Timbre);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.Timbre);

            uuid = BuscarValueXML.Buscar(nodo?.Timbre, "uuid");
            fechatimbrado = BuscarValueXML.Buscar(nodo?.Timbre, "fechatimbrado");
        }
    }
}
