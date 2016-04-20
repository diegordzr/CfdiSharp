using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoParte
    {
        /// <comentarios/>
        [XmlElement("InformacionAduanera")]
        public InformacionAduanera[] InformacionAduanera { get; set; }

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
        [XmlIgnore()]
        public bool ValorUnitarioSpecified { get; set; }

        /// <comentarios/>
        [XmlAttribute("importe")]
        public decimal Importe { get; set; }

        /// <comentarios/>
        [XmlIgnore()]
        public bool ImporteSpecified { get; set; }
    }
}
