using System;

namespace EfSamuariDomain
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public string Event { get; set; }

        public string Description { get; set; }
        public DateTime EventTime { get; set; }

        public virtual BattleLog BattleLog { get; set; }
        public virtual Samurai Samurai { get; set; }
        public int SamuraiId { get; set; } 
    }
}
