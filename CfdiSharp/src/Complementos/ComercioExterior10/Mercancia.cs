using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ComercioExterior10
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior")]
    public class Mercancia
    {
        [XmlElement("DescripcionesEspecificas")]
        public DescripcionEspecifica[] DescripcionesEspecificas { get; set; }


        [XmlAttribute("NoIdentificacion")]
        public string NoIdentificacion { get; set; }


        [XmlAttribute("FraccionArancelaria")]
        public CFraccionArancelaria FraccionArancelaria { get; set; }


        [XmlIgnore()]
        public bool FraccionArancelariaSpecified { get; set; }


        [XmlAttribute("CantidadAduana")]
        public decimal CantidadAduana { get; set; }


        [XmlIgnore()]
        public bool CantidadAduanaSpecified { get; set; }


        [XmlAttribute("UnidadAduana")]
        public CUnidadMedidaAduana UnidadAduana { get; set; }


        [XmlIgnore()]
        public bool UnidadAduanaSpecified { get; set; }


        [XmlAttribute("ValorUnitarioAduana")]
        public decimal ValorUnitarioAduana { get; set; }


        [XmlIgnore()]
        public bool ValorUnitarioAduanaSpecified { get; set; }


        [XmlAttribute("ValorDolares")]
        public decimal ValorDolares { get; set; }
    }
}
