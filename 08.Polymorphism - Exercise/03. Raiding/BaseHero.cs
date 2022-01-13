namespace Raiding2
{
    public abstract class BaseHero
    {

        public BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Power { get; set; }


        public virtual string CastAbility()
        {
            return $"{GetType().Name} - {Name} ";
        }
    }
}
