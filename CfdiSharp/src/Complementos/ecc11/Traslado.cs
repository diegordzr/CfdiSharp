using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ecc11
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/EstadoDeCuentaCombustible")]
    public class Traslado
    {
        [XmlAttribute("Impuesto")]
        public EstadoDeCuentaCombustibleConceptoEstadoDeCuentaCombustibleTrasladoImpuesto1 Impuesto { get; set; }


        [XmlAttribute("TasaoCuota")]
        public decimal TasaoCuota { get; set; }


        [XmlAttribute("Importe")]
        public decimal Importe { get; set; }
    }
}