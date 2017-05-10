using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain.Entities;

namespace SamuraiWEB.ViewModels
{
    public class SamuraiQuoteViewModel
    {
        public string SamuraiName { get; set; }
        public IEnumerable<QuoteViewModel> Quotes { get; set; }

        
    }
}
