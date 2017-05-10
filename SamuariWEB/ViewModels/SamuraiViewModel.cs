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

        public virtual HairCut HairCut { get; set; }
        public virtual SecretIdentity SecretIdentity { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<SamuariBattle> Battles { get; set; }
        public virtual ICollection<BattleEvent> BattleEvents { get; set; }
    }
}
