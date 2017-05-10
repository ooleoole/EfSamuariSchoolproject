using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfSamuariDomain.Entities;
using SamuraiWEB.Utilities.Mappers.Interfaces;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Utilities.Mappers
{
    public class ViewModelToModelMapper : IViewModelToModelMapper
    {
        public Samurai SamuraiViewModelToSamurai(SamuraiViewModelOLD samuraiViewModel)
        {
            return new Samurai
            {
                BattleEvents = samuraiViewModel.BattleEvents,

            };
        }

        public IEnumerable<Samurai> SamuraiViewModelsToSamurais(IEnumerable<SamuraiViewModelOLD> samuraiViewModels)
        {
            throw new NotImplementedException();
        }

        public Quote QuoteViewModelToQuote(QuoteViewModel quoteViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Quote> QuoteViewQuotesToQuotes(IEnumerable<QuoteViewModel> quoteViewModels)
        {
            throw new NotImplementedException();
        }
    }
}
