using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamuariDomain.Entities
{
    public class Stats
    {
      
        private readonly Random _random;

        public int Hp { get; set; }
        
        public int Dexterity { get; set; }
        public int Intelligens { get; set; }
        public int Vitality { get; set; }
        public int Strenght { get; set; }
        public virtual ICollection<Samurai> Samurais { get; set; }

        public Stats()
        {
            
            _random = new Random(Guid.NewGuid().GetHashCode());
            Hp = 100;
        }
        private void GenerateStats()
        {
            //+_random.Next(10, s);
            //Dexterity = +_random.Next(10, );
        }
    }
}
