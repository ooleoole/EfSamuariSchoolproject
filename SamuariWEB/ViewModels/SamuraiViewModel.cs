using System.Collections.Generic;
using EfSamuariDomain;
using EfSamuariDomain.Entities;

namespace SamuraiWEB.ViewModels
{
    public class SamuraiViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Clan { get; set; }
        public bool HasSword { get; set; }

        public Samurai Samurai { get; set; }
        public HairCut HairCut { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public ICollection<Quote> Quotes { get; set; } = new List<Quote>();
        public ICollection<SamuariBattle> Battles { get; set; } = new List<SamuariBattle>();
        public ICollection<BattleEvent> BattleEvents { get; set; } = new List<BattleEvent>();


    }
}
