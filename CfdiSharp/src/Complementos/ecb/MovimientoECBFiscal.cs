using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ecb
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ecb")]
    public class MovimientoEcbFiscal
    {
        [XmlAttribute()]
        public System.DateTime Fecha { get; set; }


        [XmlAttribute("referencia")]
        public string Referencia { get; set; }


        [XmlAttribute("descripcion")]
        public string Descripcion { get; set; }


        [XmlAttribute("RFCenajenante")]
        public string RfCenajenante { get; set; }


        [XmlAttribute("Importe")]
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