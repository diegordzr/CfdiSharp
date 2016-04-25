using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class SellerAlternatePartyIdentification
    {
        [XmlAttribute("type")]
        public SellerAlternatePartyIdentificationType Type { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }
}