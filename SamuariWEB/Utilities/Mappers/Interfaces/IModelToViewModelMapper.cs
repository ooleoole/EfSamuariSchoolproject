using System.Collections.Generic;
using EfSamuariDomain.Entities;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Utilities.Mappers.Interfaces
{
    public interface IModelToViewModelMapper
    {
        QuoteViewModel QuoteToQuoteViewModel(Quote quote);
        IEnumerable<QuoteViewModel> QuotesToQuoteViewModels(IEnumerable<Quote> quotes);
        SamuraiViewModel SamuraiToSamuraiViewModel(Samurai samurai);
        IEnumerable<SamuraiViewModel> SamuraisToSamuraiViewModels(IEnumerable<Samurai> samurais);
    }
}
