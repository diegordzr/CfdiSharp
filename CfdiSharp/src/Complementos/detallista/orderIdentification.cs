using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class OrderIdentification
    {
        [XmlElement("referenceIdentification")]
        public OrderIdentificationReferenceIdentification[] ReferenceIdentification { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime ReferenceDate { get; set; }


        [XmlIgnore()]
        public bool ReferenceDateSpecified { get; set; }
    }
}