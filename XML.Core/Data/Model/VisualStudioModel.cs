using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using XML.Core.Data.Entity.VisualStudio;
using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad;
using XML.Core.Funcionalidad.xml;

namespace XML.Core.Data.Model
{
    public class VisualStudioModel
    {
        public List<ConfigEntity> ValuesConfig;
        public List<PackagesEntity> Packages;
        public VisualStudioEntity VisualStudio;
        public Exception Error { get; set; }

        public VisualStudioModel(List<XMLNodoEntity> lstNodos)
        {
            try
            {
                Packages = new List<PackagesEntity>();
                ValuesConfig = new List<ConfigEntity>();

                if (ValidarTipoNodo.Existe(out XMLNodoEntity nodo, Sistema.Nodo.VisualStudio, lstNodos))
                {
                    VisualStudio = new VisualStudioEntity(nodo);

                    XMLNodoEntity config;
                    if (ValidarTipoNodo.Existe(out config, Sistema.Nodo.Config, lstNodos))
                    {
                        var conexion = BuscarValueXML.Buscar(config?.connectionStrings, "connectionString", Sistema.Nivel.ElementroAtributo);

                        if (config?.appSettings?.Elements()?.Any() == true)
                            ValuesConfig.AddRange(from XElement item in config.appSettings.Elements()
                                                  where ValidarItemXML.Validar(item.Name.LocalName, "add")
                                                  select new ConfigEntity(item, conexion));
                    }

                    XMLNodoEntity Pack;
                    if (ValidarTipoNodo.Existe(out Pack, Sistema.Nodo.Nuget, lstNodos))
                    {
                        var package = Pack?.Nugets?.Elements().Where(p => ValidarItemXML.Validar(p.Name.LocalName, "package")).ToList();
                        Packages.AddRange(from XElement pack in package select new PackagesEntity(pack));
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex;
            }
        }
    }
}
