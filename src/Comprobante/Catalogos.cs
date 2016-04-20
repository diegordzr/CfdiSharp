using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CfdiSharp.src.Comprobante
{
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public enum TipoDeComprobante
    {

        /// <comentarios/>
        ingreso,

        /// <comentarios/>
        egreso,

        /// <comentarios/>
        traslado,
    }
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public enum RetencionImpuesto
    {
        ISR,
        IVA,
    }

    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public enum TrasladoImpuesto
    {
        IVA,
        IEPS,
    }
}
