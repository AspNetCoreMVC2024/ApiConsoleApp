
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ApiConsoleApp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;





var httpClient = new HttpClient();
var authService = new ClassGetTokenAsync(httpClient);

string GetToken = await authService.ObtenerTokenAsync();

if (GetToken != null)
{
    Console.WriteLine($"Token obtenido: {GetToken}");
    // Aquí puedes continuar con otras operaciones usando el token.

    // Consumir la primera API

    //await F1(GetToken);

    // Consumir la segunda API
    //await F2(GetToken);

    // Consumir la tercera API
    //await F3(GetToken);

    // Consumir la cuarta API
    //await F4(GetToken);




}
else
{
    Console.WriteLine("No se pudo obtener el token.");
}









static async Task F1(string token)
{

    using HttpClient client = new HttpClient();

    // URL de la API
    string url = "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/gestionprocesosmasivos/web/masivo/consultaestadotickets?perIni=202401&perFin=202405&page=1&perPage=1";


    // Configura el HttpClient con el token
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token );




    try
    {
        // Hacer la solicitud GET
        HttpResponseMessage response = await client.GetAsync(url);

        // Asegúrate de que la solicitud fue exitosa
        response.EnsureSuccessStatusCode();

        // Leer el contenido de la respuesta
        string responseBody = await response.Content.ReadAsStringAsync();

        // Deserializar el JSON
        ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

        // Imprimir los valores deserializados
        Console.WriteLine($"Page: {apiResponse.paginacion.page}");
        Console.WriteLine($"PerPage: {apiResponse.paginacion.perPage}");
        Console.WriteLine($"TotalRegistros: {apiResponse.paginacion.totalRegistros}");

        foreach (var registro in apiResponse.registros)
        {
            Console.WriteLine($"\nShowReporteDescarga: {registro.showReporteDescarga}");
            Console.WriteLine($"PerTributario: {registro.perTributario}");
            Console.WriteLine($"NumTicket: {registro.numTicket}");
            Console.WriteLine($"FecCargaImportacion: {registro.fecCargaImportacion}");
            Console.WriteLine($"FecInicioProceso: {registro.fecInicioProceso}");
            Console.WriteLine($"CodProceso: {registro.codProceso}");
            Console.WriteLine($"DesProceso: {registro.desProceso}");
            Console.WriteLine($"CodEstadoProceso: {registro.codEstadoProceso}");
            Console.WriteLine($"DesEstadoProceso: {registro.desEstadoProceso}");
            Console.WriteLine($"NomArchivoImportacion: {registro.nomArchivoImportacion}");

            Console.WriteLine("\nDetalle del Ticket:");
            Console.WriteLine($"  NumTicket: {registro.detalleTicket.numTicket}");
            Console.WriteLine($"  FecCargaImportacion: {registro.detalleTicket.fecCargaImportacion}");
            Console.WriteLine($"  HoraCargaImportacion: {registro.detalleTicket.horaCargaImportacion}");
            Console.WriteLine($"  CodEstadoEnvio: {registro.detalleTicket.codEstadoEnvio}");
            Console.WriteLine($"  DesEstadoEnvio: {registro.detalleTicket.desEstadoEnvio}");
            Console.WriteLine($"  NomArchivoReporte: {registro.detalleTicket.nomArchivoReporte}");
            Console.WriteLine($"  CntFilasValidada: {registro.detalleTicket.cntFilasvalidada}");
            Console.WriteLine($"  CntCPError: {registro.detalleTicket.cntCPError}");
            Console.WriteLine($"  CntCPInformados: {registro.detalleTicket.cntCPInformados}");
        }
    }
    catch (HttpRequestException e)
    {
        // Manejo de errores
        Console.WriteLine($"Error al hacer la solicitud: {e.Message}");
    }



}



static async Task F2(string token)
{
    using HttpClient client = new HttpClient();

    // URL de la nueva API
    string url = "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/padron/web/omisos/140000/periodos";

    // Configura el HttpClient
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    try
    {
        // Hacer la solicitud GET
        HttpResponseMessage response = await client.GetAsync(url);

        // Asegúrate de que la solicitud fue exitosa
        response.EnsureSuccessStatusCode();

        // Leer el contenido de la respuesta
        string responseBody = await response.Content.ReadAsStringAsync();

        // Deserializar el JSON
        var apiResponse = JsonConvert.DeserializeObject<dynamic>(responseBody);

        // Imprimir los valores deserializados (ejemplo)
        Console.WriteLine($"Response: {apiResponse}");
    }
    catch (HttpRequestException e)
    {
        // Manejo de errores
        Console.WriteLine($"Error al hacer la solicitud: {e.Message}");
    }
}





static async Task F3(string token)
{
    using HttpClient client = new HttpClient();

    // URL de la nueva API
    string url = "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/gestionprocesosmasivos/web/masivo/consultaestadotickets?perIni=202312&perFin=202312&page=1&perPage=20";

    // Configura el HttpClient
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    try
    {
        // Hacer la solicitud GET
        HttpResponseMessage response = await client.GetAsync(url);

        // Asegúrate de que la solicitud fue exitosa
        response.EnsureSuccessStatusCode();

        // Leer el contenido de la respuesta
        string responseBody = await response.Content.ReadAsStringAsync();

        // Deserializar el JSON
        var apiResponse = JsonConvert.DeserializeObject<dynamic>(responseBody);

        // Imprimir los valores deserializados (ejemplo)
        Console.WriteLine($"Response: {apiResponse}");
    }
    catch (HttpRequestException e)
    {
        // Manejo de errores
        Console.WriteLine($"Error al hacer la solicitud: {e.Message}");
    }





}


static async Task F4(string token)
{
    using HttpClient client = new HttpClient();

    // URL de la nueva API
    string url = "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvierce/gestionprocesosmasivos/web/masivo/consultaestadotickets?perIni=202401&perFin=202408&page=1&perPage=1&numTicket=20240300000003";

    // Configura el HttpClient
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    try
    {
        // Hacer la solicitud GET
        HttpResponseMessage response = await client.GetAsync(url);

        // Asegúrate de que la solicitud fue exitosa
        response.EnsureSuccessStatusCode();

        // Leer el contenido de la respuesta
        string responseBody = await response.Content.ReadAsStringAsync();

        // Deserializar el JSON
        var apiResponse = JsonConvert.DeserializeObject<dynamic>(responseBody);

        // Imprimir los valores deserializados (ejemplo)
        Console.WriteLine($"Response: {apiResponse}");
    }
    catch (HttpRequestException e)
    {
        // Manejo de errores
        Console.WriteLine($"Error al hacer la solicitud: {e.Message}");
    }
}


//Deserializar el XML y Mostrar Datos en la Consola


/*

string xmlFilePath = "C:\\Users\\USUARIO\\source\\repos\\ApiConsoleApp\\ApiConsoleApp\\data\\20603324316-01-F001-0000262.xml";

Factura factura = DeserializeXml<Factura>(xmlFilePath);

if (factura != null)
{
    // Imprimir la cabecera
    Console.WriteLine("Cabecera:");
    Console.WriteLine($"ID: {factura.ID}");
    Console.WriteLine($"Fecha de Emisión: {factura.IssueDate}");
    Console.WriteLine($"Moneda: {factura.CurrencyCode}");
    //Console.WriteLine($"RUC Emisor: {factura.SupplierParty.Party.PartyIdentification.ID}");
    //Console.WriteLine($"Razón Social Emisor: {factura.SupplierParty.Party.PartyName.Name}");
    //Console.WriteLine($"RUC Receptor: {factura.CustomerParty.Party.PartyIdentification.ID}");
    //Console.WriteLine($"Razón Social Receptor: {factura.CustomerParty.Party.PartyName.Name}");
    //Console.WriteLine($"Importe Total a Pagar: {factura.MonetaryTotal.PayableAmount}");

    if (factura.SupplierParty?.Party?.PartyIdentification != null)
    {
        Console.WriteLine($"RUC Emisor: {factura.SupplierParty.Party.PartyIdentification.ID}");
    }
    else
    {
        Console.WriteLine("RUC Emisor no disponible.");
    }

    if (factura.SupplierParty?.Party?.PartyName != null)
    {
        Console.WriteLine($"Razón Social Emisor: {factura.SupplierParty.Party.PartyName.Name}");
    }
    else
    {
        Console.WriteLine("Razón Social Emisor no disponible.");
    }

    if (factura.CustomerParty?.Party?.PartyIdentification != null)
    {
        Console.WriteLine($"RUC Receptor: {factura.CustomerParty.Party.PartyIdentification.ID}");
    }
    else
    {
        Console.WriteLine("RUC Receptor no disponible.");
    }

    if (factura.CustomerParty?.Party?.PartyName != null)
    {
        Console.WriteLine($"Razón Social Receptor: {factura.CustomerParty.Party.PartyName.Name}");
    }
    else
    {
        Console.WriteLine("Razón Social Receptor no disponible.");
    }

    Console.WriteLine($"Importe Total a Pagar: {factura.MonetaryTotal?.PayableAmount}");






    // Recorrer el detalle
    Console.WriteLine("\nDetalle:");
    foreach (var line in factura.InvoiceLines)
    {
        Console.WriteLine($"ID: {line.ID}");
        Console.WriteLine($"Cantidad: {line.Quantity}");
        Console.WriteLine($"Descripción: {line.Item.Description}");
        Console.WriteLine($"Código del Producto: {line.Item.SellersItemIdentification.ID}");
        Console.WriteLine($"Monto: {line.LineExtensionAmount}");
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("No se pudo deserializar el archivo XML.");
}

static T DeserializeXml<T>(string filePath)
{
    using StreamReader reader = new StreamReader(filePath);
    XmlSerializer serializer = new XmlSerializer(typeof(T));
    return (T)serializer.Deserialize(reader);





}

*/



//Método para Deserializar el XML

static T DeserializeXml<T>(string filePath)
{
    using StreamReader reader = new StreamReader(filePath);
    XmlSerializer serializer = new XmlSerializer(typeof(T));
    return (T)serializer.Deserialize(reader);
}





//Código para Mostrar la Cabecera y Recorrer el Detalle

string xmlFilePath2 = "C:\\Users\\USUARIO\\source\\repos\\ApiConsoleApp\\ApiConsoleApp\\data\\20603324316-01-F001-0000301.xml";

Invoice factura2 = DeserializeXml<Invoice>(xmlFilePath2);

if (factura2 != null)
{
    // Imprimir la cabecera
    Console.WriteLine("Cabecera:");
    Console.WriteLine($"ID: {factura2.ID}");
    Console.WriteLine($"Fecha de Emisión: {factura2.IssueDate}");
    Console.WriteLine($"Moneda: {factura2.DocumentCurrencyCode}");
    Console.WriteLine($"RUC Emisor: {factura2.SupplierParty.Party.PartyIdentification.ID}");
    Console.WriteLine($"Razón Social Emisor: {factura2.SupplierParty.Party.PartyLegalEntity.RegistrationName}");
    Console.WriteLine($"RUC Receptor: {factura2.CustomerParty.Party.PartyIdentification.ID}");
    Console.WriteLine($"Razón Social Receptor: {factura2.CustomerParty.Party.PartyLegalEntity.RegistrationName}");
    Console.WriteLine($"Importe Total a Pagar: {factura2.MonetaryTotal.PayableAmount}");

    // Recorrer el detalle
    Console.WriteLine("\nDetalle:");
    foreach (var line in factura2.InvoiceLines)
    {
        Console.WriteLine($"ID: {line.ID}");
        Console.WriteLine($"Cantidad: {line.Quantity}");
        Console.WriteLine($"Descripción: {line.Item.Description}");
        Console.WriteLine($"Código del Producto: {line.Item.SellersItemIdentification.ID}");
        Console.WriteLine($"Monto: {line.LineExtensionAmount}");
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("No se pudo deserializar el archivo XML.");
}



