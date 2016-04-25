using System.Xml.Serialization;

namespace CfdiSharp.Complementos.iedu
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/iedu")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/iedu", IsNullable = false)]
    public class InstEducativas
    {
        public InstEducativas()
        {
            this.Version = "1.0";
        }


        [XmlAttribute("version")]
        public string Version { get; set; }


        [XmlAttribute("nombreAlumno")]
        public string NombreAlumno { get; set; }


        [XmlAttribute("CURP")]
        public string Curp { get; set; }


        [XmlAttribute("nivelEducativo")]
        public InstEducativasNivelEducativo NivelEducativo { get; set; }


        [XmlAttribute("autRVOE")]
        public string AutRvoe { get; set; }


        [XmlAttribute("rfcPago")]
        public string RfcPago { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/iedu")]
    public enum InstEducativasNivelEducativo
    {

        [XmlEnum("Preescolar")]
        Preescolar,

        [XmlEnum("Primaria")]
        Primaria,

        [XmlEnum("Secundaria")]
        Secundaria,


        [XmlEnum("Profesional técnico")]
        Profesionaltécnico,


        [XmlEnum("Bachillerato o su equivalente")]
        Bachilleratoosuequivalente,
    }
}