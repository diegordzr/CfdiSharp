using System;
using System.Xml.Serialization;

namespace CfdiSharp.Comprobante
{
    public class InformacionAduanera
    {
        /// <comentarios/>
        [XmlAttribute("numero")]
        public string Numero { get; set; }

        /// <comentarios/>
        [XmlAttribute(DataType = "date", AttributeName = "fecha")]
        public DateTime Fecha { get; set; }

        /// <comentarios/>
        [XmlAttribute("aduana")]
        public string Aduana { get; set; }
    }
}
