using System.Xml.Serialization;

namespace CfdiSharp.Complementos.detallista
{

    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/detallista")]
    public class Currency
    {
        [XmlElement("currencyFunction")]
        public CurrencyCurrencyFunction[] CurrencyFunction { get; set; }


        public decimal RateOfChange { get; set; }


        [XmlIgnore()]
        public bool RateOfChangeSpecified { get; set; }


        [XmlAttribute("currencyISOCode")]
        public CurrencyCurrencyIsoCode CurrencyIsoCode { get; set; }
    }
}
