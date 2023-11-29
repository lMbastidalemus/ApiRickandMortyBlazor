using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SL.Models;

namespace SL.Controllers
{
    [Route("api/characters")]
    public class Characters : ControllerBase
    {
        private HttpClient _httpClient;

        public Characters()
        {
            _httpClient = new HttpClient();
        }

        [Route("")]
        [HttpGet]

        public async Task<Personajes> GetAll()
        {
            try
            {
                Personajes personajes = null;
                HttpResponseMessage httpResponseMessage = await
                    _httpClient.GetAsync("https://rickandmortyapi.com/api/character/");

                httpResponseMessage.EnsureSuccessStatusCode();

                string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<Personajes>(responseBody);

                return personajes;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
