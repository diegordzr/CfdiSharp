using System.Xml.Serialization;

namespace CfdiSharp.Complementos.consumodecombustibles
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/consumodecombustibles")]
    public class Concepto
    {
        [XmlArrayItem("Determinado", IsNullable = false)]
        public ConceptoDeterminado[] Determinados { get; set; }


        [XmlAttribute("identificador")]
        public string Identificador { get; set; }


        [XmlAttribute()]
        public System.DateTime Fecha { get; set; }


        [XmlAttribute("rfc")]
        public string Rfc { get; set; }


        [XmlAttribute("claveEstacion")]
        public string ClaveEstacion { get; set; }


        [XmlAttribute("cantidad")]
        public decimal Cantidad { get; set; }


        [XmlAttribute("nombreCombustible")]
        public string NombreCombustible { get; set; }


        [XmlAttribute("folioOperacion")]
        public string FolioOperacion { get; set; }


        [XmlAttribute("valorUnitario")]
        public decimal ValorUnitario { get; set; }


        [XmlAttribute("importe")]
        public decimal Importe { get; set; }
    }
}