using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class DeliveryNote
    {
        [XmlElement("referenceIdentification")]
        public string[] ReferenceIdentification { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime ReferenceDate { get; set; }


        [XmlIgnore()]
        public bool ReferenceDateSpecified { get; set; }
    }
}