using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace EfSamuariDomain.Entities
{
    public class Level
    {
        private readonly Random _random;
        private int _maxStatsIncresmentPool = 200;

        public int LevelNum { get; set; }
        public int Xp { get; set; }
        public int NextLevelXpLimit { get; set; }
        public int MaxHp { get; set; }
        public int MaxIntelligens { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxVitality { get; set; }
        public int MaxStrengt { get; set; }



        public Level()
        {
            LevelNum = 1;
            NextLevelXpLimit = 200;
            _random = new Random(Guid.NewGuid().GetHashCode());
            InitMaxStats();
        }

        public void GainXp(int xpGained)
        {
            Xp += xpGained;

            if (Xp > NextLevelXpLimit)
            {
                IncreaseNextLevelXpLimit();
                LevelUp();
            }
        }

        private void LevelUp()
        {
            var randomStat = GetRandomStat();
            var randomIncreasment = GetRandomStatIncreasment();
            _maxStatsIncresmentPool -= randomIncreasment;
            switch (randomStat)
            {
                case 1:
                    {
                        MaxHp += randomIncreasment * (MaxVitality / 25);
                        break;
                    }
                case 2:
                    {
                        MaxIntelligens += randomIncreasment;
                        break;
                    }
                case 3:
                    {
                        MaxDexterity += randomIncreasment;
                        break;
                    }
                case 4:
                    {
                        MaxVitality += randomIncreasment;
                        break;
                    }
                case 5:
                    {
                        MaxVitality += randomIncreasment;
                        break;
                    }
                default:
                    throw new ArgumentException("Something weird happend");

            }
        }

        private int GetRandomStatIncreasment()
        {
            return _random.Next(5, _maxStatsIncresmentPool);
        }

        private int GetRandomStat()
        {
            return _random.Next(5);
        }

        private void IncreaseNextLevelXpLimit()
        {
            NextLevelXpLimit += _random.Next(10, 40);
        }


        private void InitMaxStats()
        {
            MaxHp = 100;
            MaxIntelligens = 50;
            MaxDexterity = 50;
            MaxVitality = 50;
            MaxStrengt = 50;
        }

    }
}
