using Microsoft.AspNetCore.Mvc;

namespace Dangaran_PokemonApplication.Models
{
    public class Moves
    {
        public MoveDetail move { get; set; }
        public List<VersionGroupDetails> version_group_details { get; set; }

        public override string ToString()
        {
            if (move != null && !string.IsNullOrEmpty(move.name))
            {
                return $"Move Name: {move.name}";
            }

            return string.Empty;
        }
    }
}
