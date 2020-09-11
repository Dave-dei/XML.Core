using XML.Core.Data.Entity.xml;
using XML.Core.Data.Model;

using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using XML.Core.Funcionalidad.Archivo;

namespace XML.Core.Funcionalidad.Maping
{
    public class MapearVisualStudio
    {
        internal List<XMLNodoEntity> nodos;

        public MapearVisualStudio(XDocument xml, string rutaXML, string rutaNuget = "", string fileconfig = "")
        {
            if (string.IsNullOrWhiteSpace(rutaNuget))
                rutaNuget = BuscarFile.Buscar(rutaXML, "*packages.config");

            if (string.IsNullOrWhiteSpace(fileconfig))
            {
                fileconfig = BuscarFile.Buscar(rutaXML, "*App.config");
                fileconfig = string.IsNullOrWhiteSpace(fileconfig) ? BuscarFile.Buscar(rutaXML, "*Web.config") : fileconfig;
            }

            var xmlNuget = File.Exists(rutaNuget) ? XDocument.Load(rutaNuget) : null;
            var config = File.Exists(fileconfig) ? XDocument.Load(fileconfig) : null;

            nodos = new List<XMLNodoEntity>();
            nodos.Add(new CargarVisualStudioNodo(xml).IniciarAsync());
            nodos.Add(new CargarNugetNodo(xmlNuget).IniciarAsync());
            nodos.Add(new CargarAppSettingNodo(config).IniciarAsync());
        }


        public VisualStudioModel Mapear() => new VisualStudioModel(nodos);

    }
}
