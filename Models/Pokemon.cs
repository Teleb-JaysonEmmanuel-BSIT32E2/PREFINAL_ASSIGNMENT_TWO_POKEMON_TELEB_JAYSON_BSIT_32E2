using Microsoft.AspNetCore.Mvc;

namespace Dangaran_PokemonApplication.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public List<Moves> Moves { get; set; }
        public List<Ability> Abilities { get; set; }
        public string ImageFileName { get; set; } // Property for image filename
    }
}
