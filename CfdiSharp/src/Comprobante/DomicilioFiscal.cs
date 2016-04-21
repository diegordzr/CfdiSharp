using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{
    public class DomicilioFiscal
    {
        /// <comentarios/>
        [XmlAttribute("calle")]
        public string Calle { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("noExterior")]
        public string NoExterior { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("noInterior")]
        public string NoInterior { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("colonia")]
        public string Colonia { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("localidad")]
        public string Localidad { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("referencia")]
        public string Referencia { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("municipio")]
        public string Municipio { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("estado")]
        public string Estado { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("pais")]
        public string Pais { get; set; }

        /// <comentarios/>
        [XmlAttributeAttribute("codigoPostal")]
        public string CodigoPostal { get; set; }
    }
}
