using System;
using System.Collections.Generic;

using XML.Core.Data.Entity.xml;
using XML.Core.Data.Entity.xsd;

namespace XML.Core.Data.Model
{
    public class XSDModel
    {
        public List<ElementoEntity> Elementos;
        public Exception Error { get; set; }

        public XSDModel(List<XMLNodoEntity> nodos)
        {
            try
            {
                XMLNodoEntity nodo = nodos.Find(i => i.TipoNodo == Sistema.Nodo.xsd);
                Elementos = new List<ElementoEntity>();

                var prefix = nodo?.NodoRaiz.GetNamespaceOfPrefix("xs");

                ElementoEntity elementoRoot = new ElementoEntity(nodo?.NodoRaiz.Element(prefix + "complexType").Elements(), nodo?.NodoRaiz);
                Elementos.Add(elementoRoot);

                var subitems = nodo?.NodoRaiz.Element(prefix + "complexType")?.Element(prefix + "sequence")?.Elements();
             
                if (subitems != null)
                {
                    foreach (var item in subitems)
                    {
                        ElementoEntity elemento = new ElementoEntity(item.Element(prefix + "complexType").Elements(), item);
                        Elementos.Add(elemento);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex;
            }

        }

        public XSDModel Mapear() => this;

    }
}
