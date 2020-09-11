using System.Xml.Linq;

using XML.Core.Funcionalidad;

namespace XML.Core.Data.Entity.xsd
{
    public class AtributoEntity
    {
        public string name { get; set; }
        public string use { get; set; }
        public string tipo { get; set; }

        public AtributoEntity(XElement item)
        {
            name = BuscarValueXML.Buscar(item, "name");
            use = BuscarValueXML.Buscar(item, "use");

            var prefix = item.GetNamespaceOfPrefix("xs");
            if (!string.IsNullOrWhiteSpace(name))
            {
                foreach (var type in item.Element(prefix + "simpleType").Elements())
                {
                    tipo = BuscarValueXML.Buscar(type, "base").Replace("xs:", "");
                }
            }
        }
    }
}
