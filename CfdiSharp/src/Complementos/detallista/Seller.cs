using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class Seller
    {
        public string Gln { get; set; }


        public SellerAlternatePartyIdentification AlternatePartyIdentification { get; set; }
    }
}