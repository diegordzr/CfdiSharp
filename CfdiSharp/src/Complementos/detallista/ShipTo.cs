using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class ShipTo
    {
        public string Gln { get; set; }


        public NameAndAddress NameAndAddress { get; set; }
    }
}