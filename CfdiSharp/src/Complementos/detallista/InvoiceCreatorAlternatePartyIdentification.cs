using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class InvoiceCreatorAlternatePartyIdentification
    {
        [XmlAttribute("type")]
        public InvoiceCreatorAlternatePartyIdentificationType Type { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }
}
