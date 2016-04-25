using System.Xml.Serialization;

namespace CfdiSharp.Complementos.ecc
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ecc")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/ecc", IsNullable = false)]
    public class EstadoDeCuentaCombustible
    {
        public EstadoDeCuentaCombustible()
        {
            this.TipoOperacion = "Tarjeta";
        }


        [XmlArrayItem("ConceptoEstadoDeCuentaCombustible", IsNullable = false)]
        public Concepto[] Conceptos { get; set; }


        [XmlAttribute("tipoOperacion")]
        public string TipoOperacion { get; set; }


        [XmlAttribute("numeroDeCuenta")]
        public string NumeroDeCuenta { get; set; }


        [XmlAttribute("subTotal")]
        public decimal SubTotal { get; set; }


        [XmlIgnore()]
        public bool SubTotalSpecified { get; set; }


        [XmlAttribute("total")]
        public decimal Total { get; set; }
    }


    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ecc")]
    public enum TrasladoImpuesto
    {

        [XmlEnum("IVA")]
        Iva,

        [XmlEnum("IEPS")]
        Ieps,
    }
}