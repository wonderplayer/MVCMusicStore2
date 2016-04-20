using MVCMusicStore2.Models;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre> {
                new Genre {Name = "Disco" },
                new Genre {Name = "Jazz" },
                new Genre {Name = "Rock" }
            };
            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album" + id};
            return View(album);
        }
    }
}