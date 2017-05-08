using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamuariDomain
{
    public class SamuariBattle
    {
       
        public virtual Battle Battle { get; set; }
        public int BattleId { get; set; }
        public virtual Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }


    }
}
