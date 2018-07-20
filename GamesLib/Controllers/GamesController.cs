using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GamesLib.Models;
using System.Data.Entity;
using GamesLib.ViewModels;

namespace GamesLib.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var games = _context.Games.Include(g => g.Genres).ToList();
            return View(games);
        }

        public ActionResult Details(int id)
        {
            var game = _context.Games.Include(g => g.Genres).SingleOrDefault(g => g.Id.Equals(id));

            if (game.Equals(null))
                return HttpNotFound();

            return View(game);
        }

        public ActionResult New()
        {
            var gameGenresFromViewModel = new GameGenresFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };
            return View(gameGenresFromViewModel);
        }

        [HttpPost]
        public ActionResult Create(GameGenresFormViewModel gameGenresFromViewModel)
        {
            if (!ModelState.IsValid)
            {
                var movieFormViewModel = new GameGenresFormViewModel()
                {
                    Game = gameGenresFromViewModel.Game,
                    Genres = _context.Genres.ToList()
                };

                return View("New", movieFormViewModel);
            }

            var game = gameGenresFromViewModel.Game;
            game.Genres = new List<Genre>();
            foreach (int selectedGenre in gameGenresFromViewModel.SelectedGenres)
            {
                game.Genres.Add(_context.Genres.SingleOrDefault(g => g.Id.Equals(selectedGenre)));
            }

            _context.Games.Add(game);

            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }

        public ActionResult Delete(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id.Equals(id));

            if (game.Equals(null))
                return HttpNotFound();

            _context.Games.Remove(game);

            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }
    }
}