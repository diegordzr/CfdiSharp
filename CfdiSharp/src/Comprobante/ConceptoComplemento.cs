using System.Xml.Serialization;
using CfdiSharp.Complementos.AcreditamientoIEPS10;

namespace CfdiSharp.Comprobante
{

    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class ComplementoConcepto {
        
        [XmlElement("acreditamientoIEPS", typeof(AcreditamientoIeps), Namespace = "http://www.sat.gob.mx/acreditamiento")]
        public object Item { get; set; }
    }
}