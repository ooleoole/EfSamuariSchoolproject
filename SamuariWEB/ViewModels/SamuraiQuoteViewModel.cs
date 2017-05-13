using System.Collections.Generic;

namespace SamuraiWEB.ViewModels
{
    public class SamuraiQuoteViewModel
    {
        public string SamuraiName { get; set; }
        public IEnumerable<QuoteViewModel> Quotes { get; set; }

        
    }
}
