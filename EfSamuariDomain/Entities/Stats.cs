using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace EfSamuariDomain.Entities
{
    public class Stats
    {

        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        public float Id { get; set; }
        public float Hp { get; set; }
        public float Xp { get; set; }
        public LevelHandler Level { get; set; } = new LevelHandler();
        public float Dexterity { get; set; }
        public float Intelligens { get; set; }
        public float Vitality { get; set; }
        public float Strenght { get; set; }
        public virtual ICollection<Samurai> Samurais { get; set; }

        public Stats()
        {


            InitStats();
        }
        private void InitStats()
        {
            Hp += _random.Next(40, (int)Level.MaxHp + 1);
            Dexterity += _random.Next(10, (int)Level.MaxDexterity + 1);
            Intelligens += _random.Next(10, (int)Level.MaxIntelligens + 1);
            Vitality += _random.Next(10, (int)Level.MaxVitality + 1);
            Strenght += _random.Next(10, (int)Level.MaxStrengt + 1);
        }

        public void GainXp(float xpGained)
        {
            Xp += xpGained;
            if (Level.CheckIfLevelUp(xpGained))
            {
                do
                {
                    xpGained = xpGained - Level.NextLevelXpLimit;
                    Level.IncreaseNextLevelXpLimit();

                    Level.LevelUp();
                    IncreaseStats();
                } while (Level.CheckIfLevelUp(xpGained));

            }


        }

        private void IncreaseStats()
        {
            Hp += _random.Next((int)Level.MaxHp - (int)Hp + 1);
            Dexterity += _random.Next((int)Level.MaxDexterity - (int)Dexterity + 1);
            Intelligens += _random.Next((int)Level.MaxIntelligens - (int)Intelligens + 1);
            Vitality += _random.Next((int)Level.MaxVitality - (int)Vitality + 1);
            Strenght += _random.Next((int)Level.MaxStrengt - (int)Strenght + 1);

        }
    }
}
