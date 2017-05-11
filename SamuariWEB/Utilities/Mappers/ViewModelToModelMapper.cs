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
        public Samurai SamuraiViewModelToSamurai(SamuraiViewModel samuraiViewModel)
        {
            return new Samurai
            {
                Name = samuraiViewModel.Name,
                Clan = samuraiViewModel.Clan,
                SecretIdentity = new SecretIdentity
                {
                    RealName = samuraiViewModel.SecretIdentity
                },
                HasSword = samuraiViewModel.HasSword,
                HairCut = samuraiViewModel.HairCut

            };
        }
        public IEnumerable<Samurai> CreateSamuraiViewModelsToSamurais(IEnumerable<SamuraiViewModel> samuraiViewModels)
        {
            return samuraiViewModels.Select(SamuraiViewModelToSamurai);

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
