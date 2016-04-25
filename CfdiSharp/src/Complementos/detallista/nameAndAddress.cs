using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class NameAndAddress
    {
        [XmlElement("name")]
        public string[] Name { get; set; }


        [XmlElement("streetAddressOne")]
        public string[] StreetAddressOne { get; set; }


        [XmlElement("city")]
        public string[] City { get; set; }


        [XmlElement("postalCode")]
        public string[] PostalCode { get; set; }
    }
}