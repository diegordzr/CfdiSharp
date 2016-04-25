using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ComercioExterior10
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior")]
    public class Domicilio
    {
        [XmlAttribute("Calle")]
        public string Calle { get; set; }


        [XmlAttribute("NumeroExterior")]
        public string NumeroExterior { get; set; }


        [XmlAttribute("NumeroInterior")]
        public string NumeroInterior { get; set; }


        [XmlAttribute("Colonia")]
        public string Colonia { get; set; }


        [XmlAttribute("Localidad")]
        public string Localidad { get; set; }


        [XmlAttribute("Referencia")]
        public string Referencia { get; set; }


        [XmlAttribute("Municipio")]
        public string Municipio { get; set; }


        [XmlAttribute("Estado")]
        public string Estado { get; set; }


        [XmlAttribute("Pais")]
        public CPais Pais { get; set; }


        [XmlAttribute("CodigoPostal")]
        public string CodigoPostal { get; set; }
    }

}
