using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.UI.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            _teamService.Insert(team);
            return View("Index");
        }

        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.GetById(id);
            _teamService.Delete(value);
            return View("Index");
        }
    }
}
