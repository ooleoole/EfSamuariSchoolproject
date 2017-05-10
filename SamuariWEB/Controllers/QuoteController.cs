using EfSamuariData.Repositories;
using EfSamuariDomain.Entities;
using Microsoft.AspNetCore.Mvc;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Controllers
{
    public class QuoteController : Controller
    {
        private IRepo<Quote> _repo;

        public QuoteController(IRepo<Quote> repo)
        {
            _repo = repo;
        }

        public IActionResult GetQuotes(int id, string name)
        {
            var model = new SamuraiQuoteViewModel() { SamuraiName = name };
            model.MapQuotesToViewModel(_repo.FindAll(q => q.Samurai.Id == id));
            return View("Quote", model);
        }
    }
}