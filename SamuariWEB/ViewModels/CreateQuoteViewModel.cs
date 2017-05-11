using EfSamuariDomain.Entities;

namespace SamuraiWEB.ViewModels
{
    public class CreateQuoteViewModel
    {
        public string SamuraiQuote { get; set; }
        public QuoteType Type { get; set; }
        public string SamuraiName { get; set; }
    }
}
