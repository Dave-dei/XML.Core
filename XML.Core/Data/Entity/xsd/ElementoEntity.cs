using System.Collections.Generic;
using System.Xml.Linq;

using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.xsd
{
    public class ElementoEntity
    {
        public string name { get; set; }

        public List<AtributoEntity> atributos { get; set; }

        public ElementoEntity(IEnumerable<XElement> Elementos, XElement nodo)
        {
            atributos = new List<AtributoEntity>();
            name = BuscarValueXML.Buscar(nodo, "name");

            foreach (var item in Elementos)
            {
                var atributo = new AtributoEntity(item);

                if (!string.IsNullOrWhiteSpace(atributo.name))
                    atributos.Add(atributo);
            }
        }

    }
}
