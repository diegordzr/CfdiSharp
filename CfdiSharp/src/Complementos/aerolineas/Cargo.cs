using System.Xml.Serialization;

namespace CfdiSharp.Complementos.aerolineas
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/aerolineas")]
    public class Cargo
    {
        [XmlAttribute("CodigoCargo")]
        public string CodigoCargo { get; set; }


        [XmlAttribute("Importe")]
        public decimal Importe { get; set; }
    }
}