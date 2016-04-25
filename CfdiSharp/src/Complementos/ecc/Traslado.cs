using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ecc
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ecc")]
    public class Traslado
    {
        [XmlAttribute("impuesto")]
        public TrasladoImpuesto Impuesto { get; set; }


        [XmlAttribute("tasa")]
        public decimal Tasa { get; set; }


        [XmlAttribute("importe")]
        public decimal Importe { get; set; }
    }
}