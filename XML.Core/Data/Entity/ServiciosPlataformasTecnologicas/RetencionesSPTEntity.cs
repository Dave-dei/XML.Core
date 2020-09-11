
using XML.Core.Data.Entity.xml;
using System.Collections.Generic;

namespace XML.Core.Data.Entity.ServiciosPlataformasTecnologicas
{
    public struct RetencionesSPTEntity
    {
        public bool existeNodo { get; set; }
        public string Version { get; set; }
        public string CveRetencion { get; set; }
        public string FolioInt { get; set; }
        public string Sello { get; set; }
        public string NumeroCertificado { get; set; }
        public string Certificado { get; set; }
        public string FechaExpedicion { get; set; }



        public RetencionesSPTEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.RetencionesSPT);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.RetencionesSPT);

            Version = nodo?.NodoRaiz?.Attribute("Version").Value;
            CveRetencion = nodo?.NodoRaiz?.Attribute("CveRetenc").Value;
            FolioInt = nodo?.NodoRaiz?.Attribute("FolioInt").Value;
            Sello = nodo?.NodoRaiz?.Attribute("Sello").Value;
            NumeroCertificado = nodo?.NodoRaiz?.Attribute("NumCert").Value;
            Certificado = nodo?.NodoRaiz?.Attribute("Cert").Value;
            FechaExpedicion = nodo?.NodoRaiz?.Attribute("FechaExp").Value;
        }
    }
}
