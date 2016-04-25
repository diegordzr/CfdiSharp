using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CfdiSharp.src.Comprobante;


namespace CfdiSharp.Comprobante
{
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
    public class Comprobante
    {
        public Comprobante()
        {
            Version = "3.2";
            SchemaLocation = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd";
        }

        public Comprobante(string xml)
        {
            var c = Util.Util.Derialize<Comprobante>(xml);
            this.Version = c.Version;
            this.Total = c.Total;
            this.TipoDeComprobante = c.TipoDeComprobante;
            this.TipoCambio = c.TipoCambio;
            this.SubTotal = c.SubTotal;
            this.SerieFolioFiscalOrig = c.SerieFolioFiscalOrig;
            this.Serie = c.Serie;
            this.Sello = c.Sello;
            this.SchemaLocation = c.SchemaLocation;
            this.Receptor = c.Receptor;
            this.NumCtaPago = c.NumCtaPago;
            this.NoCertificado = c.NoCertificado;
            this.MotivoDescuento = c.MotivoDescuento;
            this.MontoFolioFiscalOrigSpecified = c.MontoFolioFiscalOrigSpecified;
            this.MontoFolioFiscalOrig = c.MontoFolioFiscalOrig;
            this.Moneda = c.Moneda;
            this.MetodoDePago = c.MetodoDePago;
            this.LugarExpedicion = c.LugarExpedicion;
            this.Impuestos = c.Impuestos;
            this.FormaDePago = c.FormaDePago;
            this.FolioFiscalOrig = c.FolioFiscalOrig;
            this.Folio = c.Folio;
            this.FechaFolioFiscalOrigSpecified = c.FechaFolioFiscalOrigSpecified;
            this.FechaFolioFiscalOrig = c.FechaFolioFiscalOrig;
            this.Fecha = c.Fecha;
            this.Emisor = c.Emisor;
            this.DescuentoSpecified = c.DescuentoSpecified;
            this.Descuento = c.Descuento;
            this.CondicionesDePago = c.CondicionesDePago;
            this.Conceptos = c.Conceptos;
            this.Complemento = c.Complemento;
            this.Certificado = c.Certificado;
            this.Addenda = c.Addenda;
        }

        [XmlAttributeAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }

        public Emisor Emisor { get; set; }
        public Receptor Receptor { get; set; }
        
        [XmlArrayItemAttribute("Concepto", IsNullable = false)]
        public Concepto[] Conceptos { get; set; }
        public Impuestos Impuestos { get; set; }
        
        public Complemento Complemento { get; set; }
        public Addenda Addenda { get; set; }
        
        [XmlAttributeAttribute("version")]
        public string Version { get; set; }
        
        [XmlAttributeAttribute("serie")]
        public string Serie { get; set; }

        [XmlAttributeAttribute("folio")]
        public string Folio { get; set; }

        [XmlAttributeAttribute("fecha")]
        public DateTime Fecha { get; set; }

        [XmlAttributeAttribute("sello")]
        public string Sello { get; set; }

        [XmlAttributeAttribute("formaDePago")]
        public string FormaDePago { get; set; }

        [XmlAttributeAttribute("noCertificado")]
        public string NoCertificado { get; set; }

        [XmlAttribute("certificado")]
        public string Certificado { get; set; }

        [XmlAttributeAttribute("condicionesDePago")]
        public string CondicionesDePago { get; set; }

        [XmlAttributeAttribute("subTotal")]
        public decimal SubTotal { get; set; }

        [XmlAttributeAttribute("descuento")]
        public decimal Descuento { get; set; }

        [XmlIgnoreAttribute()]
        public bool DescuentoSpecified { get; set; }

        [XmlAttributeAttribute("motivoDescuento")]
        public string MotivoDescuento { get; set; }

        [XmlAttributeAttribute("TipoCambio")]
        public string TipoCambio { get; set; }

        [XmlAttributeAttribute("Moneda")]
        public string Moneda { get; set; }

        [XmlAttributeAttribute("total")]
        public decimal Total { get; set; }

        [XmlAttributeAttribute("tipoDeComprobante")]
        public TipoDeComprobante TipoDeComprobante { get; set; }

        [XmlAttributeAttribute("metodoDePago")]
        public string MetodoDePago { get; set; }

        [XmlAttributeAttribute("LugarExpedicion")]
        public string LugarExpedicion { get; set; }

        [XmlAttributeAttribute("NumCtaPago")]
        public string NumCtaPago { get; set; }

        [XmlAttributeAttribute("FolioFiscalOrig")]
        public string FolioFiscalOrig { get; set; }

        [XmlAttributeAttribute("SerieFolioFiscalOrig")]
        public string SerieFolioFiscalOrig { get; set; }

        [XmlAttributeAttribute("FechaFolioFiscalOrig")]
        public DateTime FechaFolioFiscalOrig { get; set; }

        [XmlIgnoreAttribute()]
        public bool FechaFolioFiscalOrigSpecified { get; set; }

        [XmlAttributeAttribute("MontoFolioFiscalOrig")]
        public decimal MontoFolioFiscalOrig { get; set; }

        [XmlIgnoreAttribute()]
        public bool MontoFolioFiscalOrigSpecified { get; set; }

        public override string ToString()
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");

            ns.Add("donat", "http://www.sat.gob.mx/donat");
            ns.Add("acreditamiento", "http://www.sat.gob.mx/acreditamiento");
            ns.Add("aerolineas", "http://www.sat.gob.mx/aerolineas");
            ns.Add("certificadodestruccion", "http://www.sat.gob.mx/certificadodestruccion");
            ns.Add("registrofiscal", "http://www.sat.gob.mx/registrofiscal");
            ns.Add("ComercioExterior", "http://www.sat.gob.mx/ComercioExterior");
            ns.Add("consumodecombustibles", "http://www.sat.gob.mx/consumodecombustibles");

            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            return Util.Util.Serialize(this, ns);
        }
    }
}
