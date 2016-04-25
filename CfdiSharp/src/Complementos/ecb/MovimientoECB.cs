using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ecb
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ecb")]
    public class MovimientoEcb
    {
        [XmlAttribute()]
        public System.DateTime Fecha { get; set; }


        [XmlAttribute("referencia")]
        public string Referencia { get; set; }


        [XmlAttribute("descripcion")]
        public string Descripcion { get; set; }


        [XmlAttribute("importe")]
        public decimal Importe { get; set; }


        [XmlAttribute("moneda")]
        public string Moneda { get; set; }


        [XmlAttribute("saldoInicial")]
        public decimal SaldoInicial { get; set; }


        [XmlIgnore()]
        public bool SaldoInicialSpecified { get; set; }


        [XmlAttribute("saldoAlCorte")]
        public decimal SaldoAlCorte { get; set; }


        [XmlIgnore()]
        public bool SaldoAlCorteSpecified { get; set; }
    }
}