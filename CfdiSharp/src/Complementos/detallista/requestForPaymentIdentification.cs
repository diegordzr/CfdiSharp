using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class RequestForPaymentIdentification
    {
        public RequestForPaymentIdentificationEntityType EntityType { get; set; }
    }
}