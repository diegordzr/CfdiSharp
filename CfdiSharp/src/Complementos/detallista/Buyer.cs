using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class Buyer
    {
        public string Gln { get; set; }


        public ContactInformation ContactInformation { get; set; }
    }
}