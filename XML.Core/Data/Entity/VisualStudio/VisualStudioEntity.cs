using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad;
using XML.Core.Funcionalidad.xml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML.Core.Data.Entity.VisualStudio
{
    public struct VisualStudioEntity
    {
        public int TotalDependencias { get; set; }
        public string AssemblyName { get; set; }
        public string TargetFrameworkVersion { get; set; }
        public string PlatformTarget { get; set; }
        public List<string> Proyectos { get; set; }

        public VisualStudioEntity(XMLNodoEntity nodo)
        {

            AssemblyName = BuscarValueXML.Buscar(nodo?.PropertyGroup, "AssemblyName");
            TargetFrameworkVersion = BuscarValueXML.Buscar(nodo?.PropertyGroup, "TargetFrameworkVersion");
            PlatformTarget = BuscarValueXML.Buscar(nodo?.PropertyGroup, "PlatformTarget");

            var item = BuscarElementosXML.Buscar(nodo?.ItemGroup, "ProjectReference");
            Proyectos = new List<string>();
            if (item?.Any() == true)
            {
                Proyectos.AddRange(from XElement x in item.Elements()
                                   where ValidarItemXML.Validar(x.Name.LocalName, "Name")
                                   select BuscarValueXML.Buscar(x, "Name",Sistema.Nivel.Raiz));
            }

            TotalDependencias = Proyectos.Count;
 

        }
    }
}
