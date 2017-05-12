using EfSamuariDomain.Entities;
using EfSamuariDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SamuraiWEB.Utilities.Mappers;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Controllers
{
    public class SamuraiController : Controller
    {

        private readonly IRepo<Samurai> _repo;

        public SamuraiController(IRepo<Samurai> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(CreateSamuriaViewModel model)
        {


            if (ModelState.IsValid)
            {
                var samurai = Mapper.ViewModelToModelMapping.
                    CreateSamuraiViewModelToSamurai(model);
                _repo.Add(samurai);
                //samurai = _repo.FindAll(s=>s.Name==model.Name).FirstOrDefault();
                return RedirectToAction("Index", "Home");
            }

            return View("Create");
        }
    }
}
