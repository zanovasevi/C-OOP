namespace BorderControl.Factories
{
    public class CitizenFactory
    {
        public ICitizen GetCitizen(string[] args)
        {
            ICitizen citizen = null;

            string name = args[0];
            int age = int.Parse(args[1]);
            string id = args[2];

            citizen = new Citizen(name, age, id);

            return citizen;
        }
    }
}
