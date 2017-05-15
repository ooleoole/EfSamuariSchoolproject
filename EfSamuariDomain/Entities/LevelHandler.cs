using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using Remotion.Linq.Utilities;

namespace EfSamuariDomain.Entities
{
    public class LevelHandler
    {

        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        private float _maxStatsIncresmentPool = 200;

        public int Id { get; set; }
        public double Level { get; set; }
        public double NextLevelXpLimit { get; set; }
        public double MaxHp { get; set; }
        public double MaxIntelligens { get; set; }
        public double MaxDexterity { get; set; }
        public double MaxVitality { get; set; }
        public double MaxStrengt { get; set; }



        public LevelHandler()
        {
            Level = 1;
            NextLevelXpLimit = 100;

            InitMaxStats();
        }

        public bool CheckIfLevelUp(double xpGaind)
        {
            return xpGaind > NextLevelXpLimit;

        }



        public void LevelUp()
        {
            IncreaseNextLevelXpLimit();
            do IncreaseStats();
            while (_maxStatsIncresmentPool > 0);
            Level++;
            ResetMaxStatsIncresemntPool();

        }

        private void ResetMaxStatsIncresemntPool()
        {
            _maxStatsIncresmentPool = 200;
        }

        public void IncreaseNextLevelXpLimit()
        {
            NextLevelXpLimit += _random.Next(10, 40) * (Level * 2);
        }

        private void IncreaseStats()
        {
            var randomStat = GetRandomStat();
            var randomIncreasment = GetRandomStatIncreasment();
            _maxStatsIncresmentPool -= randomIncreasment;
            switch (randomStat)
            {
                case 1:
                    {
                        MaxHp += randomIncreasment * (MaxVitality / 2);
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
                        MaxStrengt += randomIncreasment;
                        break;
                    }
                default:
                    throw new ArgumentException("Something weird happend");
            }
        }

        private int GetRandomStatIncreasment()
        {
            _maxStatsIncresmentPool = _maxStatsIncresmentPool < 0 ? 0 : _maxStatsIncresmentPool;
            return _random.Next(1, (int)_maxStatsIncresmentPool + 1);
        }

        private int GetRandomStat()
        {
            return _random.Next(1, 6);
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
