using EfSamuariDomain;
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
        public IActionResult Create(SamuraiViewModel model)
        { 
            AutoMapper.Map<Samurai>(model);  
            if (ModelState.IsValid)
            {
                
            }

            return View();
        }
    }
}
