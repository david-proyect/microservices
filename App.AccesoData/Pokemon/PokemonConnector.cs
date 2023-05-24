using App.Transversal.DTO.Pokemon;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.AccesoData.Pokemon
{
    public class PokemonConnector
    {

        public async Task<PokemonDTO> GetPokemon(string idPokemon)
        {
            string url = "https://pokeapi.co/api/v2/pokemon-form/" + idPokemon;

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            PokemonDTO pokemon = JsonConvert.DeserializeObject<PokemonDTO>(responseBody);

            return pokemon;

        }

    }
}
