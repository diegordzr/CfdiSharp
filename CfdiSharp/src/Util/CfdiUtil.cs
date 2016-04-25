using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace CfdiSharp.Util
{
        public static class Util
        {
            public static void WriteToFile(string xml, string path, bool bom)
            {
                Encoding encoding = new UTF8Encoding(bom);
                var stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                TextWriter writer = new StreamWriter(stream, encoding);
                writer.Write(xml);
                writer.Flush();
                writer.Close();
            }

            public static void WriteToFile(string xml, string path)
            {
                WriteToFile(xml, path, true);
            }

            public static string ComprobanteToString(Comprobante.Comprobante comprobante)
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
                ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                return Serialize(comprobante, ns);
            }

            public static string Serialize<T>(T obj, XmlSerializerNamespaces ns)
            {
                var xsSubmit = new XmlSerializer(obj.GetType());
                using (var sww = new Utf8StringWriter())
                using (var writer = XmlWriter.Create(sww, new XmlWriterSettings { Encoding = Encoding.UTF8 }))
                {
                    xsSubmit.Serialize(writer, obj, ns);
                    var xml = sww.ToString();
                    return xml;
                }
            }

            private sealed class Utf8StringWriter : StringWriter
            {
                public override Encoding Encoding { get { return Encoding.UTF8; } }
            }

            public static class Validador
            {
                private static bool _success;
                public static string UltimoMensaje;

                public static bool Validar(Comprobante.Comprobante cfdi)
                {
                    return Validar(cfdi.ToString());
                }

                public static bool Validar(string xml)
                {
                    _success = true;
                    UltimoMensaje = string.Empty;

                    var doc = new XmlDocument();
                    doc.LoadXml(xml);

                    //System.Xml.Schema
                    var eventHandler = new ValidationEventHandler(ValidationCallback);
                    doc.Schemas.Add("http://www.sat.gob.mx/cfd/3", "http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd");
                    doc.Schemas.Add("http://www.sat.gob.mx/donat", "http://www.sat.gob.mx/sitio_internet/cfd/donat/donat11.xsd");


                    doc.Validate(eventHandler);
                    return _success;
                }

                static void ValidationCallback(Object sender, ValidationEventArgs e)
                {
                    switch (e.Severity)
                    {
                        case XmlSeverityType.Error:
                            UltimoMensaje = e.Message;
                            _success = false;
                            break;

                        case XmlSeverityType.Warning:
                            UltimoMensaje = e.Message;
                            break;
                    }
                }
            }

            public static class Sello
            {
                public static string NoCertificado(X509Certificate2 cer)
                {
                    var ar = cer.GetSerialNumber();
                    Array.Reverse(ar);
                    return Encoding.UTF8.GetString(ar);
                }

                public static string GenerarSello(X509Certificate2 cert, string cadenaOriginal)
                {
                    Encoding encode = new UTF8Encoding();
                    var bin = encode.GetBytes(cadenaOriginal);

                    var sha = new SHA1CryptoServiceProvider();
                    var rsa = (RSACryptoServiceProvider)cert.PrivateKey;
                    var signedBin = rsa.SignData(bin, sha);

                    return Convert.ToBase64String(signedBin);
                }

                public static string GenerarNoSerie(X509Certificate2 cert)
                {
                    var serialNumber = "";
                    if (cert.SerialNumber == null) 
                        return serialNumber;

                    var chars = cert.SerialNumber.ToCharArray();
                    for (var i = 1; i < chars.Length; i += 2)
                        serialNumber += chars[i];
                    return serialNumber;
                }

                public static string GenerarCertificadoPuro64(X509Certificate2 cert)
                {
                    var rawCert = cert.GetRawCertData();
                    return Convert.ToBase64String(rawCert);
                }

                public static string GenerarCadenaOriginal(Comprobante.Comprobante cfdi)
                {
                    var xml = cfdi.ToString();
                    var doc = new XmlDocument();
                    doc.LoadXml(xml);
                    var xslt = new XslCompiledTransform();
                    xslt.Load("http://www.sat.mx/cfd/3/cadenaoriginal_3_2/cadenaoriginal_3_2.xslt");
                    
                    var ms2 = new MemoryStream();
                    xslt.Transform(doc, null, ms2);
                    ms2.Position = 3;

                    var sr = new StreamReader(ms2);
                    var cadenaOriginal = sr.ReadToEnd();
                    sr.Close();

                    return cadenaOriginal;
                }

            }
        }
    
}
