using XML.Core.Data.Entity.xml;
using XML.Core.Funcionalidad;

using System.Collections.Generic;

namespace XML.Core.Data.Entity.Nomina
{
    public struct ComprobanteEntity
    {
        public bool existeNodo { get; set; }
        public string Descuento,
            Fecha,
            Moneda,
            SubTotal,
            TipoDeComprobante,
            TipoCambio,
            Total,
            Version,
            MetodoPago,
            FormaPago,
            NoCertificado,
            Certificado,
            Sello,
            Folio,
            Serie,
            LugarExpedicion;

        public ComprobanteEntity(List<XMLNodoEntity> lstNodos)
        {
            XMLNodoEntity nodo = lstNodos.Find(i => i.TipoNodo == Sistema.Nodo.Comprobante);
            existeNodo = lstNodos.Exists(i => i.TipoNodo == Sistema.Nodo.Comprobante);

            Fecha = BuscarValueXML.Buscar(nodo?.Comprobante, "fecha");
            TipoDeComprobante = BuscarValueXML.Buscar(nodo?.Comprobante, "tipodecomprobante");
            Version = BuscarValueXML.Buscar(nodo?.Comprobante, "version");
            SubTotal = BuscarValueXML.Buscar(nodo?.Comprobante, "subtotal");
            Descuento = BuscarValueXML.Buscar(nodo?.Comprobante, "descuento");
            TipoCambio = BuscarValueXML.Buscar(nodo?.Comprobante, "tipocambio");
            Moneda = BuscarValueXML.Buscar(nodo?.Comprobante, "moneda");
            Total = BuscarValueXML.Buscar(nodo?.Comprobante, "total");
            Version = BuscarValueXML.Buscar(nodo?.Comprobante, "Version");
            MetodoPago = BuscarValueXML.Buscar(nodo?.Comprobante, "MetodoPago");
            FormaPago = BuscarValueXML.Buscar(nodo?.Comprobante, "FormaPago");
            NoCertificado = BuscarValueXML.Buscar(nodo?.Comprobante, "NoCertificado");
            Certificado = BuscarValueXML.Buscar(nodo?.Comprobante, "Certificado");
            Sello = BuscarValueXML.Buscar(nodo?.Comprobante, "Sello");
            Folio = BuscarValueXML.Buscar(nodo?.Comprobante, "Folio");
            Serie = BuscarValueXML.Buscar(nodo?.Comprobante, "Serie");
            LugarExpedicion = BuscarValueXML.Buscar(nodo?.Comprobante, "LugarExpedicion");
        }

    }
}
