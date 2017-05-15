using System;
using EfSamuariDomain.Entities.Moves;

namespace EfSamuariDomain.Entities
{
    public class OffensiveCombatMove
    {
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        private readonly Samurai _samurai;

        public OffensiveCombatMove(Samurai samurai)
        {
            _samurai = samurai;
        }


        public double KickBaseDamage { get; set; } = 10;
        public double KickPrecision { get; set; } = 3;
        public double PunchBaseDamage { get; set; } = 5;
        public double PunchPrescision { get; set; } = 2;
        // public int LevelMultiplier { get; set; } = 100;

        public Kick Kick()
        {
            var randomNum = _random.Next(0, 30);
            var damage = randomNum == 0
                ? 0
                : KickBaseDamage * (_samurai.Stats.Strenght / 2) *
                  (_samurai.Stats.Dexterity / 10) *
                  (KickPrecision * (_samurai.Stats.Intelligens / 100)) /
                  (randomNum * (_samurai.Stats.Xp / 6666.6665 + (6666 / 6666.6665)));
            return new Kick { Damage = damage };
        }

        public Punch Punch()
        {
            var randomNum = _random.Next(5, 40);
            var damage = (PunchBaseDamage * (_samurai.Stats.Strenght / 2) *
                         (_samurai.Stats.Dexterity / 10) *
                         (PunchPrescision * (_samurai.Stats.Intelligens / 100)) /
                         (randomNum * (_samurai.Stats.Xp / 6666.6665 + (6666 / 6666.6665))));
            return new Punch { Damage = damage };
        }
    }
}