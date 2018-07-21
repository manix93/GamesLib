using System.Linq;
using System.Web.Configuration;
using System.Web.Http;
using GamesLib.Models;

namespace GamesLib.Controllers.API
{
    public class GamesController : ApiController
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult DeleteGame(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id.Equals(id));

            if (game.Equals(null))
                return NotFound();

            _context.Games.Remove(game);
            _context.SaveChanges();

            return Ok();
        }
    }
}
