using App.AccesoData.Pokemon;
using App.Transversal.DTO.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio.Servicios.Pokemon
{
    public class PokemonServices
    {
        public async Task<PokemonDTO> GetPokemon(string idPokemon)
        {
            PokemonConnector pokemonConnector = new PokemonConnector();

           return await pokemonConnector.GetPokemon(idPokemon);

        }
    }
}
