using System.Xml.Serialization;
using CfdiSharp.Complementos;

namespace CfdiSharp.Comprobante
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Complemento
    {
        [XmlElement(typeof(Donatarias), Namespace = "http://www.sat.gob.mx/donat")]
        public Donatarias Donatarias { get; set; }
    }
}
