using XML.Core.Data.Entity.xml;
using XML.Core.Data.Model;
using XML.Core.Interfaz;

using System.Collections.Generic;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.Maping
{
    public class MapearServiciosPlataformasTecnologicas : ICargarXML
    {
        internal List<XMLNodoEntity> nodos;

        public MapearServiciosPlataformasTecnologicas(XDocument xml)
        {
            nodos = new List<XMLNodoEntity>();

            if (xml != null)
            {
                nodos.Add(new CargarSPTNodo(xml).IniciarAsync());
                nodos.Add(new CargarRetencionSPTNodo(xml).IniciarAsync());
                nodos.Add(new CargarPeriodoNodo(xml).IniciarAsync());
                nodos.Add(new CargarTotalesSPTNodo(xml).IniciarAsync());
                nodos.Add(new CargarEmisorNodo(xml).IniciarAsync());
                nodos.Add(new CargarReceptorNodo(xml).IniciarAsync());
            }
        }

        public XMLFactoryModel Mapear() => new ServiciosPlataformasTecnologicasModel(nodos);

    }
}
