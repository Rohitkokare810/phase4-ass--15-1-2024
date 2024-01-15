using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class PlayersController : Controller
    {
        static List<Player> players = new List<Player>()
    {
        new Player(){PId=1,PName="Rohit",PCountry="India",PType="Batsman"},
        new Player(){PId=2,PName="Virat",PCountry="India",PType="Batsman"},
        new Player(){PId=3,PName="Maxwell",PCountry="Aus",PType="All-Rounder"},
        new Player(){PId=4,PName="Dhoni",PCountry="India",PType="WK/Bat"},
        new Player(){PId=5,PName="K.L.Rahul",PCountry="India",PType="Batsman"},
    };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player pla)
        {
            if (ModelState.IsValid)
            {
                players.Add(pla);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
