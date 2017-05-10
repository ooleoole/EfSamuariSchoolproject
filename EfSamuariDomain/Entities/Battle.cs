using System;
using System.Collections.Generic;

namespace EfSamuariDomain.Entities
{
    public class Battle
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Descrpition { get; set; }
        public virtual DateTime StarTime { get; set; }
        public virtual  DateTime EndTime { get; set; }

        public virtual ICollection<SamuariBattle> Battles { get; set; } = new List<SamuariBattle>();
        public virtual BattleLog BattleLog { get; set; }

       

    }
}
