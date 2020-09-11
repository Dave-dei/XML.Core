using XML.Core.Funcionalidad;

using System.Xml.Linq;

namespace XML.Core.Data.Entity.Nomina
{
    public struct EmisorEntity
    {
        public string RegistroPatronal { get; set; }
        public EmisorEntity(XElement Emisor)
        {
            RegistroPatronal = BuscarValueXML.Buscar(Emisor, "RegistroPatronal");
        }
    }
}
