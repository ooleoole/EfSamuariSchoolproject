using System;
using EfSamuariDomain.Entities.Moves;

namespace EfSamuariDomain.Entities
{
    public class DefensiveCombatMove
    {
        private readonly Samurai _samurai;
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());


        public int DodgeBaseReduction { get; set; } = 10;
        public int DodgePrecision { get; set; } = 4;
        public int BlockBaseReduction { get; set; } = 5;
        public int BlockPrecision { get; set; } = 2;

        public DefensiveCombatMove(Samurai samurai)
        {
            _samurai = samurai;
        }
        public Dodge Dodge()
        {
            var randomNum = _random.Next(1, 30);
            var damageReduction = DodgeBaseReduction * (_samurai.Stats.Dexterity / 2) *
                                  (_samurai.Stats.Strenght / 5) *
                                  (DodgePrecision * _samurai.Stats.Intelligens) /
                                  (randomNum * 1000);
            return new Dodge { DamageReduction = damageReduction };
        }

        public Block Block()
        {
            var randomNum = _random.Next(1, 20);
            var damageReduction = DodgeBaseReduction * (_samurai.Stats.Dexterity / 2) *
                                  (_samurai.Stats.Strenght / 4) *
                                  (BlockPrecision * _samurai.Stats.Intelligens) /
                                  (randomNum * 1000);
            return new Block { DamageReduction = damageReduction };
        }
    }
}
