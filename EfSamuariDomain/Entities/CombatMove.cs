using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamuariDomain.Entities
{
    public class CombatMove
    {
        public DefensiveCombatMove DefensiveCombatMove { get; set; }
        public OffensiveCombatMove OffensiveCombatMove { get; set; }

        public CombatMove(Samurai samurai)
        {
            DefensiveCombatMove = new DefensiveCombatMove(samurai);
            OffensiveCombatMove = new OffensiveCombatMove(samurai);
        }
    }
}
