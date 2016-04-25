using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ComercioExterior10
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior")]
    public class Receptor
    {
        [XmlAttribute("Curp")]
        public string Curp { get; set; }


        [XmlAttribute("NumRegIdTrib")]
        public string NumRegIdTrib { get; set; }
    }
}
