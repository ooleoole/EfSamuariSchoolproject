using System;
using System.Collections.Generic;

namespace EfSamuariDomain
{
    public class Samurai
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

    public enum HairCut
    {
        Mullet,
        Gay,
        Nice
    }
}
