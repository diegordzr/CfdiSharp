using System.Xml.Serialization;

namespace CfdiSharp.Complementos.consumodecombustibles
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/consumodecombustibles")]
    public class ConceptoDeterminado
    {
        [XmlAttribute("impuesto")]
        public Impuesto Impuesto { get; set; }


        [XmlAttribute("tasa")]
        public decimal Tasa { get; set; }


        [XmlAttribute("importe")]
        public decimal Importe { get; set; }
    }
}