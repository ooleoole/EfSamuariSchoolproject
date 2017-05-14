using System;

namespace EfSamuariDomain.Entities
{
    public class BattleEvent
    {
        public int Id { get; set; }
        

        public string Description { get; set; }
        public DateTime EventTime { get; set; }
        //public CombatMove CombatMove { get; set; }
        //public virtual Samurai 
        public virtual Samurai Samurai { get; set; }
       
    }
}
