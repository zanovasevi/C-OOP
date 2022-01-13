namespace BorderControl
{
    public class Rebel : IRebel, IBuyer
    {
        private const int increasedFood = 5;
        private int food = 0;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = food;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Group { get; set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += increasedFood;
        }
    }
}
