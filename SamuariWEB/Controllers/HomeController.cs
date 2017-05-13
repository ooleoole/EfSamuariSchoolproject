using EfSamuariDomain.Entities;
using EfSamuariDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var samurais = _repo.AllInclude(p => p.SecretIdentity, p1 => p1.Quotes);
            model.Samurais = Mapper.ModelToViewModelMapping.SamuraisToSamuraiViewModels(samurais);
            return View(nameof(Index), model);
        }


    }
}
