using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Impuestos
    {
        /// <comentarios/>
        [XmlArrayItem("Retencion", IsNullable = false)]
        public Retencion[] Retenciones { get; set; }

        /// <comentarios/>
        [XmlArrayItem("Traslado", IsNullable = false)]
        public Traslado[] Traslados { get; set; }

        /// <comentarios/>
        [XmlAttribute("totalImpuestosRetenidos")]
        public decimal TotalImpuestosRetenidos { get; set; }

        /// <comentarios/>
        [XmlIgnore()]
        public bool TotalImpuestosRetenidosSpecified { get; set; }

        /// <comentarios/>
        [XmlAttribute("totalImpuestosTrasladados")]
        public decimal TotalImpuestosTrasladados { get; set; }

        /// <comentarios/>
        [XmlIgnore()]
        public bool TotalImpuestosTrasladadosSpecified { get; set; }
    }
}
