

using System.Collections.Generic;
using System.Xml.Linq;

using XML.Core.Data.Model;

namespace XML.Core.Data.Entity.xml
{
    public class XMLNodoEntity
    {
        public XMLNodoEntity()
        {
            lstServicios = new List<DetalleServicioSPTModel>();
            ImportesRetenidos = new List<XElement>();
            PropertyGroup = new List<XElement>();
        }
        public Sistema.Nodo TipoNodo { get; set; }


        public List<DetalleServicioSPTModel> lstServicios;
        public List<XElement> ImportesRetenidos { get; set; }

        public XElement Servicios { get; set; }
        public XElement NodoRaiz { get; set; }
        public XElement PlataformasTecnologicas { get; set; }
        public XElement Comprobante { get; set; }
        public XElement Concepto { get; set; }
        public XElement Emisor { get; set; }
        public XElement Retencion { get; set; }
        public XElement Impuestos { get; set; }
        public XElement Periodo { get; set; }
        public XElement Receptor { get; set; }
        public XElement Nacional { get; set; }
        public XElement Totales { get; set; }
        public XElement Traslado { get; set; }
        public XElement Timbre { get; set; }
        public XElement Complemento { get; set; }
        public XElement Nomina { get; set; }
        public XElement Percepcion { get; set; }
        public XElement Deducciones { get; set; }
        public List<XElement> PropertyGroup { get; set; }
        public List<XElement> ItemGroup { get; set; }
        public List<XElement> Nugets { get; set; }
        public XElement appSettings { get; set; }
        public XElement connectionStrings { get; set; }
    }

}
