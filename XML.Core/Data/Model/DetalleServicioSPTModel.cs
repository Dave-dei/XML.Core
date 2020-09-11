using System.Collections.Generic;
using System.Xml.Linq;

namespace XML.Core.Data.Model
{
    public struct DetalleServicioSPTModel
    {
        public XElement DetallesDelServicio { get; set; }
        public List<XElement> ImpuestosTrasladadosdelServicio { get; set; }
        public XElement ContribucionGubernamental { get; set; }
        public XElement ComisionDelServicio { get; set; }

        public DetalleServicioSPTModel(XElement DetallesDelServicio, List<XElement> ImpuestosTrasladadosdelServicio, XElement ContribucionGubernamental, XElement ComisionDelServicio)
        {
            this.DetallesDelServicio = DetallesDelServicio;
            this.ImpuestosTrasladadosdelServicio = ImpuestosTrasladadosdelServicio;
            this.ContribucionGubernamental = ContribucionGubernamental;
            this.ComisionDelServicio = ComisionDelServicio;
        }
    }
}
