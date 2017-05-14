using System;
using System.Collections.Generic;

namespace EfSamuariDomain.Entities
{
    public class Battle
    {
        public int Id { get; set; }
        public string Descrpition { get; set; }
        public virtual DateTime StarTime { get; set; }
        public virtual  DateTime EndTime { get; set; }

        public virtual Samurai PlayerOne { get; set; }
        public virtual  Samurai PlayerTwo { get; set; }
        
        public virtual BattleLog BattleLog { get; set; }

       

    }
}
