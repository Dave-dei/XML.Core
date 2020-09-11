using XML.Core.Funcionalidad;

using System.Xml.Linq;

namespace XML.Core.Data.Entity.VisualStudio
{
    public struct ConfigEntity
    {
        public string connectionStrings { get; set; }
        public string key { get; set; }
        public string value { get; set; }

        public ConfigEntity(XElement config, string conexionvalue)
        {
            connectionStrings = conexionvalue;
            key = BuscarValueXML.Buscar(config, "key");
            value = BuscarValueXML.Buscar(config, "value");
        }
    }
}
