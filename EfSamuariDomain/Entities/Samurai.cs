using System.Collections.Generic;

namespace EfSamuariDomain.Entities
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Clan { get; set; }
        public bool HasSword { get; set; }

        public CombatMove CombatMove { get; set; }
        public virtual Stats Stats { get; set; }  = new Stats();
        public virtual HairCut HairCut { get; set; }
        public virtual SecretIdentity SecretIdentity { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();
        public virtual ICollection<SamuariBattle> Battles { get; set; } = new List<SamuariBattle>();
        public virtual ICollection<BattleEvent> BattleEvents { get; set; } = new List<BattleEvent>();

        public Samurai()
        {
            CombatMove = new CombatMove(this);
        }
    }

   
    public enum HairCut
    {
        Mullet,
        Gay,
        Nice
    }
}
