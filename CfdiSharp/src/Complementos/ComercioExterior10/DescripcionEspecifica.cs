using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ComercioExterior10
{

    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior")]
    public class DescripcionEspecifica
    {
        [XmlAttribute("Marca")]
        public string Marca { get; set; }


        [XmlAttribute("Modelo")]
        public string Modelo { get; set; }


        [XmlAttribute("SubModelo")]
        public string SubModelo { get; set; }


        [XmlAttribute("NumeroSerie")]
        public string NumeroSerie { get; set; }
    }
}
