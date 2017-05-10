using EfSamuariDomain.Entities;
using EfSamuariDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SamuraiWEB.Utilities;
using SamuraiWEB.Utilities.Mappers;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Controllers
{
    public class QuoteController : Controller
    {
        private readonly IRepo<Quote> _repo;

        public QuoteController(IRepo<Quote> repo)
        {
            _repo = repo;
        }

        public IActionResult GetQuotes(int id, string name)
        {
            var model = new SamuraiQuoteViewModel { SamuraiName = name };
            var quotes = _repo.FindAll(q => q.Samurai.Id == id);
            model.Quotes = Mapper.ModelToViewModelMapping.QuotesToQuoteViewModels(quotes);
            return View("Quote", model);
        }
    }
}