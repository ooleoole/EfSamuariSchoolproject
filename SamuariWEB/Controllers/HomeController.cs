using EfSamuariDomain.Entities;
using EfSamuariDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SamuraiWEB.Utilities;
using SamuraiWEB.Utilities.Mappers;
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
            var samurais = _repo.GetAll();
            model.Samurais = Mapper.ModelToViewModelMapping.SamuraisToSamuraiViewModels(samurais);
            return View(nameof(Index), model);
        }

    
    }
}
