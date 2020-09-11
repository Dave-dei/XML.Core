using XML.Core.Funcionalidad;
using System.Xml.Linq;

namespace XML.Core.Data.Entity.VisualStudio
{
    public struct PackagesEntity
    {
        public string id { get; set; }
        public string version { get; set; }
        public string targetFramework { get; set; }

        public PackagesEntity(XElement package)
        {
            id = BuscarValueXML.Buscar(package, "id");
            version = BuscarValueXML.Buscar(package, "version");
            targetFramework = BuscarValueXML.Buscar(package, "targetFramework");
        }

    }
}
