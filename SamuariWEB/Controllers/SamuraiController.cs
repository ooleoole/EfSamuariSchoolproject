using EfSamuariDomain;
using EfSamuariDomain.Entities;
using EfSamuariDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Remotion.Linq.Utilities;
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
            var teast = new Samurai()
            {
                Clan = "Bajs",
                HasSword = true,
                Name = "testetste",
                SecretIdentity = new SecretIdentity()
                {
                    Id = 32,
                    RealName = "Olapopp"
                }

            };
            var test=  AutoMapper.Map<Samurai>(teast);  
            if (ModelState.IsValid)
            {
                
            }

            return View();
        }
    }
}
