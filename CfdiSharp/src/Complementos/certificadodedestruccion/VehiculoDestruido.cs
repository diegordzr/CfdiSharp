using System.Xml.Serialization;

namespace CfdiSharp.Complementos.certificadodedestruccion
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/certificadodestruccion")]
    public class VehiculoDestruido
    {
        [XmlAttribute("Marca")]
        public string Marca { get; set; }


        [XmlAttribute("TipooClase")]
        public string TipooClase { get; set; }


        [XmlAttribute("Año")]
        public int Año { get; set; }


        [XmlAttribute("Modelo")]
        public string Modelo { get; set; }


        [XmlAttribute("NIV")]
        public string Niv { get; set; }


        [XmlAttribute("NumSerie")]
        public string NumSerie { get; set; }


        [XmlAttribute("NumPlacas")]
        public string NumPlacas { get; set; }


        [XmlAttribute("NumMotor")]
        public string NumMotor { get; set; }


        [XmlAttribute("NumFolTarjCir")]
        public string NumFolTarjCir { get; set; }
    }
}