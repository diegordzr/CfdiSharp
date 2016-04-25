using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ecc11
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/EstadoDeCuentaCombustible")]
    public class Concepto
    {
        [XmlArrayItem("Traslado", IsNullable = false)]
        public Traslado[] Traslados { get; set; }


        [XmlAttribute("Identificador")]
        public string Identificador { get; set; }


        [XmlAttribute()]
        public System.DateTime Fecha { get; set; }


        [XmlAttribute("Rfc")]
        public string Rfc { get; set; }


        [XmlAttribute("ClaveEstacion")]
        public string ClaveEstacion { get; set; }


        [XmlAttribute("TAR")]
        public CTar Tar { get; set; }


        [XmlIgnore()]
        public bool TarSpecified { get; set; }


        [XmlAttribute("Cantidad")]
        public decimal Cantidad { get; set; }


        [XmlAttribute("NoIdentificacion")]
        public CClaveProducto NoIdentificacion { get; set; }


        [XmlAttribute("Unidad")]
        public string Unidad { get; set; }


        [XmlAttribute("NombreCombustible")]
        public string NombreCombustible { get; set; }


        [XmlAttribute("FolioOperacion")]
        public string FolioOperacion { get; set; }


        [XmlAttribute("ValorUnitario")]
        public decimal ValorUnitario { get; set; }


        [XmlAttribute("Importe")]
        public decimal Importe { get; set; }
    }
}