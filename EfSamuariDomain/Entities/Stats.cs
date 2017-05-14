using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace EfSamuariDomain.Entities
{
    public class Stats
    {

        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        public int Id { get; set; }
        public int Hp { get; set; }
        public int Xp { get; set; }
        public LevelHandler Level { get; set; } = new LevelHandler();
        public int Dexterity { get; set; }
        public int Intelligens { get; set; }
        public int Vitality { get; set; }
        public int Strenght { get; set; }
        public virtual ICollection<Samurai> Samurais { get; set; }

        public Stats()
        {


            InitStats();
        }
        private void InitStats()
        {
            Hp += _random.Next(40, Level.MaxHp + 1);
            Dexterity += _random.Next(10, Level.MaxDexterity + 1);
            Intelligens += _random.Next(10, Level.MaxIntelligens + 1);
            Vitality += _random.Next(10, Level.MaxVitality + 1);
            Strenght += _random.Next(10, Level.MaxStrengt + 1);
        }

        public void GainXp(int xpGained)
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
            Hp += _random.Next(Level.MaxHp - Hp + 1);
            Dexterity += _random.Next(Level.MaxDexterity - Dexterity + 1);
            Intelligens += _random.Next(Level.MaxIntelligens - Intelligens + 1);
            Vitality += _random.Next(Level.MaxVitality - Vitality + 1);
            Strenght += _random.Next(Level.MaxStrengt - Strenght + 1);

        }
    }
}
