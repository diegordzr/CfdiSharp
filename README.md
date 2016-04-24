# CfdiSharp

Libreria para generar el xml del CFDI v3.2 de forma fácil y rápida.


Ejemplo de uso
```cs
var comp = new Comprobante();

comp.Fecha = DateTime.Now;
comp.FormaDePago = "PAGO EN UNA SOLA EXHIBICION";
comp.MetodoDePago = "NO IDENTIFICADO";
comp.LugarExpedicion = "San Luis Potosí";
comp.TipoDeComprobante = TipoDeComprobante.ingreso;
comp.SubTotal = 1.00m;
comp.Total = 1.16m;

//Emisor
comp.Emisor = new Emisor ();
comp.Emisor.DomicilioFiscal = new DomicilioFiscal();
comp.Emisor.Rfc = "AAA010101AAA";
comp.Emisor.DomicilioFiscal.Calle = "Himalaya";
comp.Emisor.DomicilioFiscal.Municipio = "San Luis Potosí";
comp.Emisor.DomicilioFiscal.Estado = "San Luis Potosí";
comp.Emisor.DomicilioFiscal.Pais = "México";
comp.Emisor.DomicilioFiscal.CodigoPostal = "78000";
var regimenFiscal = new RegimenFiscal { Regimen = "Régimen de las Personas Físicas con Actividades Empresariales y Profesionales" };
comp.Emisor.RegimenFiscal = new[] { regimenFiscal };

//Receptor
comp.Receptor = new Receptor ();
comp.Receptor.Domicilio = new Domicilio();
comp.Receptor.Rfc = "AAA010101AAA";
comp.Receptor.Domicilio.Pais = "México";

//Conceptos
var concepto = new Concepto();
concepto.Cantidad = 1;
concepto.Unidad = "NO APLICA";
concepto.Descripcion = "SERVICIO X";
concepto.Importe = 1.00m;
concepto.ValorUnitario = 1.00m;
comp.Conceptos = new[] { concepto };

//Impuestos
var traslado = new Traslado();
traslado.Impuesto = TrasladoImpuesto.IEPS;
traslado.Importe = 0.16m;
traslado.Tasa = 16m;
comp.Impuestos = new Impuestos();
comp.Impuestos.Traslados = new[]{ traslado };

// sellado
var cer = new X509Certificate2(@"CERAAA010101A23KEY.pfx", "12345678a", X509KeyStorageFlags.MachineKeySet);
var cadena = Util.Sello.GenerarCadenaOriginal(comp);

comp.NoCertificado = Util.Sello.NoCertificado(cer);
comp.Certificado = Convert.ToBase64String(cer.RawData);
comp.Sello = Util.Sello.GenerarSello(cer, cadena);

//xml del cfdi listo para timbrarse con cualquier PAC
var xmlString = comp.ToString()

```

Convertir archivo.cer y archivo.key a archivo.pfx con OpenSSL

```sh
pkcs8 -in <ruta del archivo key>.key -inform DER -out <ruta del archive de salida>.pem
x509 -in <ruta archivo certificado>.cer –inform DER -out <ruta archivo destino>.pem
pkcs12 -export -inkey <ruta archivo keypem>.pem -in <ruta archivo cerpem>.pem -out <ruta archivo final>.pfx
```
