using System.Xml.Serialization;
using CfdiSharp.src.Comprobante;

namespace CfdiSharp.Comprobante
{
    public class Traslado
    {
        /// <comentarios/>
        [XmlAttributeAttribute("impuesto")]
        public TrasladoImpuesto Impuesto { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("tasa")]
        public decimal Tasa { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("importe")]
        public decimal Importe { get; set; }
    }
}
