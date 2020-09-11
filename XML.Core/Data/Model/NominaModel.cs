
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using XML.Core.Data.Entity.Nomina;
using XML.Core.Data.Entity.xml;

namespace XML.Core.Data.Model
{
    public class NominaModel : XMLFactoryModel
    { 
        public NominaEntity Nomina;
        public List<PercepcionesEntity> Percepciones;
        public List<DeduccionesEntity> Deducciones;
        public ConceptoEntity Concepto;
        public ComprobanteEntity Comprobante;


        public NominaModel(List<XMLNodoEntity> nodos) : base(nodos)
        {
            try
            {
                XMLNodoEntity nodo = nodos.Find(i => i.TipoNodo == Sistema.Nodo.Nomina);
                existeNodo = nodos.Exists(i => i.TipoNodo == Sistema.Nodo.Nomina);
              
                Nomina = new NominaEntity(nodo?.Nomina);
                Concepto = new ConceptoEntity(nodos);
                Comprobante = new ComprobanteEntity(nodos);

                Deducciones = new List<DeduccionesEntity>();
                Percepciones = new List<PercepcionesEntity>();

                if (nodo?.Percepcion.Elements().Any() == true)
                {
                    Percepciones.AddRange(from XElement item in nodo?.Percepcion.Elements()
                                             select new PercepcionesEntity(nodo?.Percepcion, item));
                }
                if (nodo?.Deducciones.Elements().Any() == true)
                {
                    Deducciones.AddRange(from XElement item in nodo?.Deducciones.Elements()
                                            select new DeduccionesEntity(nodo?.Deducciones, item));
                } 
            }
            catch (System.Exception ex)
            {
                Error = ex;
            }

        }

        public override XMLFactoryModel Mapear() => this;
        
    }
}
