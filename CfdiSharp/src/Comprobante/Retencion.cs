using System.Xml.Serialization;
using CfdiSharp.src.Comprobante;

namespace CfdiSharp.Comprobante
{
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Retencion
    {
        /// <comentarios/>
        [XmlAttribute("impuesto")]
        public RetencionImpuesto Impuesto { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("importe")]
        public decimal Importe { get; set; }
    }
}
