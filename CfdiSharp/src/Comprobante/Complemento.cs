using System.Xml.Serialization;
using CfdiSharp.Complementos.aerolineas;
using CfdiSharp.Complementos.AcreditamientoIEPS10;
using CfdiSharp.Complementos.certificadodedestruccion;
using CfdiSharp.Complementos.cfdiregistrofiscal;
using CfdiSharp.Complementos.consumodecombustibles;
using CfdiSharp.Complementos.ComercioExterior10;
using CfdiSharp.Complementos.donat11;

namespace CfdiSharp.Comprobante
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Complemento
    {
        [XmlElement(typeof(Donatarias), Namespace = "http://www.sat.gob.mx/donat", ElementName = "Donatarias")]
        [XmlElement(typeof(AcreditamientoIeps), Namespace = "http://www.sat.gob.mx/acreditamiento", ElementName = "acreditamientoIEPS")]
        [XmlElement(typeof(Aerolineas), Namespace = "http://www.sat.gob.mx/aerolineas", ElementName = "Aerolineas")]
        [XmlElement(typeof(CertificadoDeDestruccion), Namespace = "http://www.sat.gob.mx/certificadodestruccion", ElementName = "certificadodestruccion")]
        [XmlElement(typeof(CfdiRegistroFiscal), Namespace = "http://www.sat.gob.mx/registrofiscal", ElementName = "CFDIRegistroFiscal")]
        [XmlElement(typeof(ComercioExterior), Namespace = "http://www.sat.gob.mx/ComercioExterior", ElementName = "ComercioExterior")]
        [XmlElement(typeof(ConsumoDeCombustibles), Namespace = "http://www.sat.gob.mx/consumodecombustibles", ElementName = "ConsumoDeCombustibles")]
        
        public object[] Any { get; set; }
    }
}
