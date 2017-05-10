using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain.Entities;

namespace SamuraiWEB.ViewModels
{
    public class SamuraiQuoteViewModel
    {
        public string SamuraiName { get; set; }
        public IEnumerable<QuoteViewModel> Quotes { get; set; }

        public void MapQuotesToViewModel(IEnumerable<Quote> quotes)
        {
            Quotes = quotes.Select(quote => new QuoteViewModel
            {
                Id = quote.Id,
                SamuraiName = quote.Samurai.Name,
                SamuraiQuote = quote.SamuraiQuote,
                Type = quote.Type
            });

        }
    }
}
