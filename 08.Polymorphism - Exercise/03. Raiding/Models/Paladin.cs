namespace Raiding2.Models
{
    public class Paladin : BaseHero
    {
        private const int power = 100;

        public Paladin(string name) : base(name)
        {
            Power = power;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"healed for {Power}";
        }
    }
}
