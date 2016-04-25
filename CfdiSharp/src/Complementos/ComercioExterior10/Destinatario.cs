using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ComercioExterior10
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior")]
    public class Destinatario
    {
        public Domicilio Domicilio { get; set; }


        [XmlAttribute("NumRegIdTrib")]
        public string NumRegIdTrib { get; set; }


        [XmlAttribute("Rfc")]
        public string Rfc { get; set; }


        [XmlAttribute("Curp")]
        public string Curp { get; set; }


        [XmlAttribute("Nombre")]
        public string Nombre { get; set; }
    }
}
