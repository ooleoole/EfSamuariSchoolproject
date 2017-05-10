using EfSamuariData.Repositories;
using EfSamuariDomain;
using Microsoft.AspNetCore.Mvc;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepo<Samurai> _repo;

        public HomeController(IRepo<Samurai> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var model = new StartPageViewModel();
            model.MapSamuriasToViewModel(_repo.GetAll());
            return View(nameof(Index), model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
