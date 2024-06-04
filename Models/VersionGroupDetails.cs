using Microsoft.AspNetCore.Mvc;

namespace Dangaran_PokemonApplication.Models
{
    public class VersionGroupDetails
    {
        public int level_learned_at { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
        public VersionGroup version_group { get; set; }

        public override string ToString()
        {
            return $"Level Learned At: {level_learned_at}, Move Learn Method: {move_learn_method?.name}, Version Group: {version_group?.name}";
        }
    }
}
