using XML.Core.Data.Entity.xml;
using XML.Core.Entity.xml;

using System;
using System.Collections.Generic;

namespace XML.Core.Data.Model
{
    public abstract class XMLFactoryModel
    {
        public bool existeNodo { get; set; }
        public Exception Error { get; set; }
        public EmisorEntity Emisor { get; set; }
        public ReceptorEntity Receptor { get; set; }
        public TimbreEntity Timbre { get; set; }

        public XMLFactoryModel(List<XMLNodoEntity> nodos)
        {
            Emisor = new EmisorEntity(nodos);
            Receptor = new ReceptorEntity(nodos);
            Timbre = new TimbreEntity(nodos);
        }

        public abstract XMLFactoryModel Mapear();
    }
}
