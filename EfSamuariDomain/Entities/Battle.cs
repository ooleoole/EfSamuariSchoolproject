using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamuariDomain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Descrpition { get; set; }
        public virtual DateTime StarTime { get; set; }
        public virtual  DateTime EndTime { get; set; }

        public virtual ICollection<SamuariBattle> Battles { get; set; }
		public virtual BattleLog BattleLog { get; set; }

    }
}
