using System;
using EfSamuariDomain.Entities.Moves;

namespace EfSamuariDomain.Entities
{
    public class DefensiveCombatMove
    {
        private readonly Samurai _samurai;
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());


        public double DodgeBaseReduction { get; set; } = 10;
        public double DodgePrecision { get; set; } = 4;
        public double BlockBaseReduction { get; set; } = 5;
        public double BlockPrecision { get; set; } = 2;

        public DefensiveCombatMove(Samurai samurai)
        {
            _samurai = samurai;
        }
        public Dodge Dodge()
        {
            var randomNum = _random.Next(1, 30);
            var damageReduction = (DodgeBaseReduction * (_samurai.Stats.Dexterity / 2) *
                                  (_samurai.Stats.Strenght / 10) *
                                  (DodgePrecision * _samurai.Stats.Intelligens / 100) /
                                  (randomNum * (_samurai.Stats.Xp / 6666.6665 + (6666 / 6666.6665))));
            return new Dodge { DamageReduction = damageReduction };
        }

        public Block Block()
        {
            var randomNum = _random.Next(1, 20);
            var damageReduction = DodgeBaseReduction * (_samurai.Stats.Dexterity / 2) *
                                  (_samurai.Stats.Strenght / 10) *
                                  (BlockPrecision * _samurai.Stats.Intelligens / 100) /
                                  (randomNum * (_samurai.Stats.Xp / 6666.6665 + (6666 / 6666.6665)));
            return new Block { DamageReduction = damageReduction };
        }
    }
}
