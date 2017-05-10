using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfSamuariDomain.Entities;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Utilities.Mappers.Interfaces
{
    public interface IViewModelToModelMapper
    {
        Samurai SamuraiViewModelToSamurai(SamuraiViewModelOLD samuraiViewModel);
        IEnumerable<Samurai> SamuraiViewModelsToSamurais(IEnumerable<SamuraiViewModelOLD> samuraiViewModels);
        Quote QuoteViewModelToQuote(QuoteViewModel quoteViewModel);
        IEnumerable<Quote> QuoteViewQuotesToQuotes(IEnumerable<QuoteViewModel> quoteViewModels);

    }
}
