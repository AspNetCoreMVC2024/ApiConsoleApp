using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsoleApp
{
    public class ClassGetTokenAsync
    {


        private readonly HttpClient _httpClient;

        public ClassGetTokenAsync(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ObtenerTokenAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api-seguridad.sunat.gob.pe/v1/clientessol/193a391d-f9f7-4115-b745-ad59e4bb353b/oauth2/token/");

            request.Headers.Add("Cookie", "TS019e7fc2=014dc399cb89a9d70d405db1375dc7c9e9d9909bfcfab5ae6d60d853904bce3d03f7221e539682ae27319e08b553229998604828c6");

            var collection = new List<KeyValuePair<string, string>>
        {
            new("grant_type", "password"),
            new("scope", "https://api-sire.sunat.gob.pe"),
            new("client_id", "193a391d-f9f7-4115-b745-ad59e4bb353b"),
            new("client_secret", "RoQUuQ2O5xOU4hcvJsDEiw=="),
            new("username", "20603324316CHERUSEQ"),
            new("password", "lathelfis")
        };

            var content = new FormUrlEncodedContent(collection);
            request.Content = content;

            var response = await _httpClient.SendAsync(request);

            try
            {
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                string token = responseObject.access_token;
                return token;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al obtener el token: {ex.Message}");
                return null;
            }
        }





    }   
}
