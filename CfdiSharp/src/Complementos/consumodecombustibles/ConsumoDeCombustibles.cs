using System.Xml.Serialization;
using CfdiSharp.Comprobante;

namespace CfdiSharp.Complementos.consumodecombustibles
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/consumodecombustibles")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/consumodecombustibles", IsNullable = false)]
    public class ConsumoDeCombustibles : ComplementoCfdi
    {
        public ConsumoDeCombustibles()
        {
            Version = "1.0";
            TipoOperacion = "monedero electrónico";
            SchemaLocation = "http://www.sat.gob.mx/consumodecombustibles http://www.sat.gob.mx/sitio_internet/cfd/consumodecombustibles/consumodecombustibles.xsd";
        }

        [XmlArrayItem("ConceptoConsumoDeCombustibles", IsNullable = false)]
        public Concepto[] Conceptos { get; set; }


        [XmlAttribute("version")]
        public string Version { get; set; }


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
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/consumodecombustibles")]
    public enum Impuesto
    {

        [XmlEnum("IVA")]
        Iva,

        [XmlEnum("IEPS")]
        Ieps,
    }
}