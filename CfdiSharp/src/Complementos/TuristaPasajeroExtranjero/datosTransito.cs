using System.Xml.Serialization;

namespace CfdiSharp.Complementos.TuristaPasajeroExtranjero
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TuristaPasajeroExtranjero")]
    public class DatosTransito
    {
        [XmlAttribute("Via")]
        public TuristaPasajeroExtranjeroDatosTransitoVia Via { get; set; }


        [XmlAttribute("TipoId")]
        public string TipoId { get; set; }


        [XmlAttribute("NumeroId")]
        public string NumeroId { get; set; }


        [XmlAttribute("Nacionalidad")]
        public string Nacionalidad { get; set; }


        [XmlAttribute("EmpresaTransporte")]
        public string EmpresaTransporte { get; set; }


        [XmlAttribute("IdTransporte")]
        public string IdTransporte { get; set; }
    }
}