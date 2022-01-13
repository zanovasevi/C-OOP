namespace Raiding2.Models
{
    public class Warrior : BaseHero
    {
        private const int power = 100;

        public Warrior(string name) : base(name)
        {
            Power = power;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"hit for {Power} damage";
        }
    }
}
