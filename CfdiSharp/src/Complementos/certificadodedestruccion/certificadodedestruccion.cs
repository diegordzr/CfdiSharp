using System.Xml.Serialization;
using CfdiSharp.Comprobante;

namespace CfdiSharp.Complementos.certificadodedestruccion
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/certificadodestruccion")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/certificadodestruccion", IsNullable = false)]
    public class CertificadoDeDestruccion : ComplementoCfdi
    {
        public CertificadoDeDestruccion()
        {
            Version = "1.0";
            SchemaLocation = "http://www.sat.gob.mx/certificadodestruccion http://www.sat.gob.mx/sitio_internet/cfd/certificadodestruccion/certificadodedestruccion.xsd";
        }

        public VehiculoDestruido VehiculoDestruido { get; set; }


        public InformacionAduanera InformacionAduanera { get; set; }


        [XmlAttribute("Version")]
        public string Version { get; set; }


        [XmlAttribute("Serie")]
        public CTipoSerie Serie { get; set; }


        [XmlAttribute("NumFolDesVeh")]
        public string NumFolDesVeh { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(Namespace = "http://www.sat.gob.mx/certificadodestruccion")]
    public enum CTipoSerie
    {


        [XmlEnum("SERIE A")]
        Seriea,


        [XmlEnum("SERIE B")]
        Serieb,


        [XmlEnum("SERIE C")]
        Seriec,


        [XmlEnum("SERIE D")]
        Seried,


        [XmlEnum("SERIE E")]
        Seriee,
    }
}