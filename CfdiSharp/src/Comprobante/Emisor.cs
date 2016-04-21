using System.Collections.Generic;

namespace CfdiSharp.Comprobante
{
    public class Emisor
    {
        /// <comentarios/>
        public DomicilioFiscal DomicilioFiscal { get; set; }

        /// <comentarios/>
        public Domicilio ExpedidoEn { get; set; }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("RegimenFiscal")]
        public RegimenFiscal[] RegimenFiscal { get; set; }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute("rfc")]
        public string Rfc { get; set; }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute("nombre")]
        public string Nombre { get; set; }
    }
}
