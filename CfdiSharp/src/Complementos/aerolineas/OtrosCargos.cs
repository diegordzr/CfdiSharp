using System.Xml.Serialization;

namespace CfdiSharp.Complementos.aerolineas
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/aerolineas")]
    public class OtrosCargos
    {
        [XmlElement("Cargo")]
        public Cargo[] Cargo { get; set; }


        [XmlAttribute("TotalCargos")]
        public decimal TotalCargos { get; set; }
    }
}