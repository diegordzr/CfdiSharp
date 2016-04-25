using System.Xml.Serialization;
using CfdiSharp.Comprobante;

namespace CfdiSharp.Complementos.cfdiregistrofiscal
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/registrofiscal")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/registrofiscal", IsNullable = false)]
    public class CfdiRegistroFiscal : ComplementoCfdi
    {
        public CfdiRegistroFiscal()
        {
            Version = "1.0";
            SchemaLocation = "http://www.sat.gob.mx/registrofiscal http://www.sat.gob.mx/sitio_internet/cfd/cfdiregistrofiscal/cfdiregistrofiscal.xsd";
        }

        [XmlAttribute("Version")]
        public string Version { get; set; }


        [XmlAttribute("Folio")]
        public string Folio { get; set; }
    }
}