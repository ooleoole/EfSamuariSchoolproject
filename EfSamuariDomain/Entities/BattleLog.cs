using System.Collections.Generic;

namespace EfSamuariDomain.Entities
{
    public class BattleLog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BattleEvent> BattleEvents { get; set; }
        
    }
}
