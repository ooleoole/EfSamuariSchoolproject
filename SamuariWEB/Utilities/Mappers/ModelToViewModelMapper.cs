using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain.Entities;
using SamuraiWEB.Utilities.Mappers.Interfaces;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Utilities.Mappers
{
    internal class ModelToViewModelMapper : IModelToViewModelMapper
    {
        public QuoteViewModel QuoteToQuoteViewModel(Quote quote)
        {
            return new QuoteViewModel
            {
                Id = quote.Id,
                SamuraiQuote = quote.SamuraiQuote,
                Type = quote.Type
            };
        }

        public IEnumerable<QuoteViewModel> QuotesToQuoteViewModels(IEnumerable<Quote> quotes)
        {
            return quotes.Select(QuoteToQuoteViewModel);

        }

        public SamuraiViewModel SamuraiToSamuraiViewModel(Samurai samurai)
        {
            return new SamuraiViewModel
            {

                Clan = samurai.Clan,
                HairCut = samurai.HairCut,
                Id = samurai.Id,
                Name = samurai.Name,
                Quotes = QuotesToQuoteViewModels(samurai.Quotes).ToList(),
                SecretIdentity = samurai.SecretIdentity == null ? "" : samurai.SecretIdentity.RealName,
                HasSword = samurai.HasSword

            };
        }

        public IEnumerable<SamuraiViewModel> SamuraisToSamuraiViewModels(IEnumerable<Samurai> samurais)
        {
            return samurais.Select(SamuraiToSamuraiViewModel);

        }

    }
}
