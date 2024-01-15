using Microsoft.AspNetCore.Mvc;
using PlayerAssessment7.Models;

namespace PlayerAssessment7.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player() {PId=1,PName="Rohit",PCountry="India",PType="Bats Man" },
            new Player() {PId=2,PName="Virat",PCountry="India",PType="Bats Man" },
            new Player() {PId=3,PName="M.S Dhoni",PCountry="India",PType="W.Keeper/Bats Man" },
            new Player() {PId=4,PName="Jadeja",PCountry="India",PType="All Rounder" },

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
        public IActionResult Create(Player play)
        {
            if (ModelState.IsValid)
            {
                players.Add(play);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
