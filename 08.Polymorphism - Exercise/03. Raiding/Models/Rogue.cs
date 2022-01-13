﻿namespace Raiding2.Models
{
    public class Rogue : BaseHero
    {
        private const int power = 80;

        public Rogue(string name) : base(name)
        {
            Power = power;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"hit for {Power} damage";
        }
    }
}
