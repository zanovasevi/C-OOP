namespace BorderControl.Factories
{
    public class CitizenFactory
    {
        public Citizen GetCitizen(string[] args)
        {
            Citizen citizen = null;

            string name = args[0];
            int age = int.Parse(args[1]);
            string id = args[2];
            string birthdate = args[3];

            citizen = new Citizen(name, age, id, birthdate);

            return citizen;
        }
    }
}
