using System;
using EfSamuariDomain.Entities.Moves;

namespace EfSamuariDomain.Entities
{
    public class OffensiveCombatMove
    {
        private readonly Samurai _samurai;
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());


        public int KickBaseDamage { get; set; } = 10;
        public int KickPrecision { get; set; } = 4;
        public int PunchBaseDamage { get; set; } = 5;
        public int PunchPrescision { get; set; } = 2;

        public OffensiveCombatMove(Samurai samurai)
        {
            _samurai = samurai;

        }

        public Kick Kick()
        {
            var randomNum = _random.Next(1, 30);
            var damage = KickBaseDamage * (_samurai.Stats.Strenght / 2) *
                         (_samurai.Stats.Dexterity / 6) *
                         (KickPrecision * _samurai.Stats.Intelligens) /
                         (randomNum * 1000);
            return new Kick { Damage = damage };

        }

        public Punch Punch()
        {
            var randomNum = _random.Next(1, 20);
            var damage = PunchBaseDamage * (_samurai.Stats.Strenght / 2) *
                         (_samurai.Stats.Dexterity / 5) *
                         (PunchPrescision * _samurai.Stats.Intelligens) /
                         (randomNum * 1000);
            return new Punch { Damage = damage };

        }
    }
}
