using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain.Entities;
using SamuraiWEB.Utilities.Mappers.Interfaces;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Utilities.Mappers
{
    internal class ModelToViewModelMapper: IModelToViewModelMapper
    {
        public QuoteViewModel QuoteToQuoteViewModel(Quote quote)
        {
            return new QuoteViewModel
            {
                Id = quote.Id,
                SamuraiName = quote.Samurai.Name,
                SamuraiQuote = quote.SamuraiQuote,
                Type = quote.Type
            };
        }

        public IEnumerable<QuoteViewModel> QuotesToQuoteViewModels(IEnumerable<Quote> quotes)
        {
            return quotes.Select(quote => new QuoteViewModel
            {
                Id = quote.Id,
                SamuraiName = quote.Samurai.Name,
                SamuraiQuote = quote.SamuraiQuote,
                Type = quote.Type
            });
        }

        public SamuraiViewModelOLD SamuraiToSamuraiViewModel(Samurai samurai)
        {
            return new SamuraiViewModelOLD
            {
                BattleEvents = samurai.BattleEvents,
                Battles = samurai.Battles,
                Clan = samurai.Clan,
                HairCut = samurai.HairCut,
                Id = samurai.Id,
                Name = samurai.Name,
                Quotes = samurai.Quotes,
                SecretIdentity = samurai.SecretIdentity,
                HasSword = samurai.HasSword

            };
        }

        public IEnumerable<SamuraiViewModelOLD> SamuraisToSamuraiViewModels(IEnumerable<Samurai> samurais)
        {
            return samurais.Select(samurai => new SamuraiViewModelOLD
            {
                BattleEvents = samurai.BattleEvents,
                Battles = samurai.Battles,
                Clan = samurai.Clan,
                HairCut = samurai.HairCut,
                Id = samurai.Id,
                Name = samurai.Name,
                Quotes = samurai.Quotes,
                SecretIdentity = samurai.SecretIdentity,
                HasSword = samurai.HasSword
            });
        }

    }
}
