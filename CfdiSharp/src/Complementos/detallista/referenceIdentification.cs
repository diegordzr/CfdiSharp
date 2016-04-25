using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class ReferenceIdentification
    {
        [XmlAttribute("type")]
        public ReferenceIdentificationType Type { get; set; }


        [XmlText()]
        public string Value { get; set; }
    }
}