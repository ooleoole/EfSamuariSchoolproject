using System.Collections.Generic;
using EfSamuariDomain.Entities;

namespace SamuraiWEB.ViewModels
{
    public class CreateSamuriaViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Clan { get; set; }
        public bool HasSword { get; set; }
        public string DefeatQuote { get; set; }
        public string VictoryQuote { get; set; }
        public HairCut HairCut { get; set; }
        public string SecretIdentity { get; set; }
        public ICollection<QuoteViewModel> Quotes { get; set; } = new List<QuoteViewModel>();
    }
}
