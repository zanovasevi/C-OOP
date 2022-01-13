namespace BorderControl
{
    public class Citizen : ICitizen, IBuyer
    {
        private const int increasedFood = 10;
        private int food = 0;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = food;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public string Birthdate { get; set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += increasedFood;
        }
    }
}
