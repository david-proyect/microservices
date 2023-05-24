using App.Dominio.Servicios.Pokemon;
using App.Transversal.DTO.Pokemon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mcs_productus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpPost(Name = "GetPokemon")]
        public async Task<PokemonDTO> GetPokemon(string idPokemon)
        {
            PokemonServices pokemonServices = new PokemonServices();
            return await pokemonServices.GetPokemon(idPokemon);
        }
    }
}
