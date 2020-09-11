using XML.Core.Data.Entity.xml;
using System.Collections.Generic;

namespace XML.Core.Funcionalidad.xml
{
    public struct ValidarTipoNodo
    {
        public static bool Existe(out XMLNodoEntity nodo, Sistema.Nodo tipo, List<XMLNodoEntity> lstNodos)
        {
            nodo = lstNodos?.Find(i => i.TipoNodo == tipo) ?? new XMLNodoEntity();
            return lstNodos?.Exists(i => i.TipoNodo == tipo) == true;
        }
    }
}
