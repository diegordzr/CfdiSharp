using System.Xml.Serialization;
using CfdiSharp.Comprobante;

namespace CfdiSharp.Complementos.aerolineas
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/aerolineas")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/aerolineas", IsNullable = false)]
    public class Aerolineas : ComplementoCfdi
    {
        public Aerolineas()
        {
            Version = "1.0";
            SchemaLocation = "http://www.sat.gob.mx/aerolineas http://www.sat.gob.mx/sitio_internet/cfd/aerolineas/aerolineas.xsd";
        }

        public OtrosCargos OtrosCargos { get; set; }


        [XmlAttribute("Version")]
        public string Version { get; set; }


        [XmlAttribute("TUA")]
        public decimal Tua { get; set; }
    }
}