﻿using EfSamuariDomain.Interfaces;

namespace EfSamuariDomain.Entities.Moves
{
    public class Dodge : IDefensiveMove
    {

        public double DamageReduction { get; set; }

    }
}
