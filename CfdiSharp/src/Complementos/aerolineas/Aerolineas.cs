using System.Xml.Serialization;

namespace CfdiSharp.Complementos.aerolineas
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/aerolineas")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/aerolineas", IsNullable = false)]
    public class Aerolineas
    {
        public Aerolineas()
        {
            Version = "1.0";
            SchemaLocation = "http://www.sat.gob.mx/aerolineas http://www.sat.gob.mx/sitio_internet/cfd/aerolineas/aerolineas.xsd";
        }

        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }

        public OtrosCargos OtrosCargos { get; set; }


        [XmlAttribute("Version")]
        public string Version { get; set; }


        [XmlAttribute("TUA")]
        public decimal Tua { get; set; }
    }
}