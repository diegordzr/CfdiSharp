using System.Xml.Serialization;
using CfdiSharp.Complementos.AcreditamientoIEPS10;

namespace CfdiSharp.Comprobante
{
    public class Concepto
    {
        [XmlElement("ComplementoConcepto", typeof(ComplementoConcepto))]
        [XmlElement("CuentaPredial", typeof(CuentaPredial))]
        [XmlElement("InformacionAduanera", typeof(InformacionAduanera))]
        [XmlElement("Parte", typeof(ComprobanteConceptoParte))]
        public object[] Items { get; set; }

        /// <comentarios/>
        [XmlAttribute("cantidad")]
        public decimal Cantidad { get; set; }

        /// <comentarios/>
        [XmlAttribute("unidad")]
        public string Unidad { get; set; }

        /// <comentarios/>
        [XmlAttribute("noIdentificacion")]
        public string NoIdentificacion { get; set; }

        /// <comentarios/>
        [XmlAttribute("descripcion")]
        public string Descripcion { get; set; }

        /// <comentarios/>
        [XmlAttribute("valorUnitario")]
        public decimal ValorUnitario { get; set; }

        /// <comentarios/>
        [XmlAttribute("importe")]
        public decimal Importe { get; set; }
    }
}
