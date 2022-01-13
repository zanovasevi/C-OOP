namespace BorderControl.Factories
{
    public class PetFactory
    {
        public IPet GetPet(string[] args)
        {
            IPet pet = null;

            string name = args[1];
            string birthdate = args[2];

            pet = new Pet(name, birthdate);
            return pet;
        }
    }
}
