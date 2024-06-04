using Microsoft.AspNetCore.Mvc;


namespace Dangaran_PokemonApplication.Controllers
{
    public class PokemonController : Controller
    {
        private readonly HttpClient _client;

        public PokemonController()
        {
            _client = new HttpClient();
        }
    }
}
