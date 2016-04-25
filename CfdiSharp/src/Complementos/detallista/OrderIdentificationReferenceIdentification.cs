using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class OrderIdentificationReferenceIdentification
    {
        public OrderIdentificationReferenceIdentification()
        {
            Type = OrderIdentificationReferenceIdentificationType.On;
        }


        [XmlAttribute("type")]
        public OrderIdentificationReferenceIdentificationType Type { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }
}
