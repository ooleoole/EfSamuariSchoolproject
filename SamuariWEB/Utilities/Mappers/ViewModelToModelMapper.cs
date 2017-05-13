using System;
using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain.Entities;
using SamuraiWEB.Utilities.Mappers.Interfaces;
using SamuraiWEB.ViewModels;

namespace SamuraiWEB.Utilities.Mappers
{
    public class ViewModelToModelMapper : IViewModelToModelMapper
    {
        public Samurai CreateSamuraiViewModelToSamurai(CreateSamuriaViewModel createSamuriaViewModel)
        {
            return new Samurai
            {
                Name = createSamuriaViewModel.Name,
                Clan = createSamuriaViewModel.Clan,
                SecretIdentity = new SecretIdentity
                {
                    RealName = createSamuriaViewModel.SecretIdentity
                },
                HasSword = createSamuriaViewModel.HasSword,
                HairCut = createSamuriaViewModel.HairCut,
                Quotes = new List<Quote> { new Quote
                {
                    SamuraiQuote = createSamuriaViewModel.VictoryQuote,
                    Type = QuoteType.VictoryQuote
                },
                new Quote
                {
                    SamuraiQuote = createSamuriaViewModel.DefeatQuote,
                    Type = QuoteType.DefeatQuote
                }}

            };
        }
        public IEnumerable<Samurai> CreateSamuraiViewModelsToSamurais(IEnumerable<CreateSamuriaViewModel> createSamuriaViewModels)
        {
            return createSamuriaViewModels.Select(CreateSamuraiViewModelToSamurai);

        }

        public Samurai SamuraiViewModelToSamurai(SamuraiViewModel samuraiViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Samurai> SamuraiViewModelsToSamurais(IEnumerable<SamuraiViewModel> samuraiViewModels)
        {
            return samuraiViewModels.Select(SamuraiViewModelToSamurai);

        }

        public Quote QuoteViewModelToQuote(QuoteViewModel quoteViewModel)
        {
            throw new NotImplementedException();
        }

        public Quote CreateQuoteViewModelToQuote(CreateQuoteViewModel quoteViewModel)
        {
            return new Quote()
            {
                
            };
        }

        public IEnumerable<Quote> QuoteViewQuotesToQuotes(IEnumerable<QuoteViewModel> quoteViewModels)
        {
            throw new NotImplementedException();
        }
    }
}
