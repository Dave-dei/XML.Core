using XML.Core.Data.Entity.xml;
using XML.Core.Data.Model;
using XML.Core.Interfaz;

using System.Collections.Generic;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad.Maping
{
    public class MapearNomina : ICargarXML
    {
        internal List<XMLNodoEntity> nodos;

        public MapearNomina(XDocument xml)
        {
            nodos = new List<XMLNodoEntity>();

            if (xml != null)
            {
                nodos.Add(new CargarNominaNodo(xml).IniciarAsync());
                nodos.Add(new CargarConceptoNodo(xml).IniciarAsync());
                nodos.Add(new CargarComprobanteNodo(xml).IniciarAsync());
                nodos.Add(new CargarEmisorNodo(xml).IniciarAsync());
                nodos.Add(new CargarReceptorNodo(xml).IniciarAsync());
                nodos.Add(new CargarTimbreNodo(xml).IniciarAsync());
            }
        }

        public XMLFactoryModel Mapear() => new NominaModel(nodos);

    }
}
