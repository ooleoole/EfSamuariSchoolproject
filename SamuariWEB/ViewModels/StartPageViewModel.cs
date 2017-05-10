using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain;

namespace SamuraiWEB.ViewModels
{
    public class StartPageViewModel
    {

        public IEnumerable<SamuraiViewModel> Samurais { get; set; }


        public StartPageViewModel()
        {
            Samurais = new List<SamuraiViewModel>();
        }
        public void MapSamuriasToViewModel(IEnumerable<Samurai> samurais)
        {
            Samurais = samurais.Select(samurai => new SamuraiViewModel()
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
