using System.Collections.Generic;
using System.Xml.Linq;

using XML.Core.Data.Entity.xml;
using XML.Core.Data.Model;
using XML.Core.Funcionalidad.xml;

namespace XML.Core.Funcionalidad.Maping
{
    public class MapearXSD 
    {
        internal List<XMLNodoEntity> nodos;

        public MapearXSD(XDocument xml)
        {
            nodos = new List<XMLNodoEntity>();

            if (xml != null)
                nodos.Add(new CargarXSDNodo(xml).IniciarAsync());
        }

        public XSDModel Mapear() => new XSDModel(nodos);

    }
}
