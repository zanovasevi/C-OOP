namespace BorderControl.Factories
{
    public class CitizenFactory
    {
        public ICitizen GetCitizen(string[] args)
        {
            ICitizen citizen = null;

            string name = args[1];
            int age = int.Parse(args[2]);
            string id = args[3];
            string birthdate = args[4];

            citizen = new Citizen(name, age, id, birthdate);

            return citizen;
        }
    }
}
