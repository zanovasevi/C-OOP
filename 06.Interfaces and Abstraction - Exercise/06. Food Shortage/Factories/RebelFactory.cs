namespace BorderControl.Factories
{
    public class RebelFactory
    {
        public Rebel GetRebel(string[] args)
        {
            Rebel rebel = null;

            string name = args[0];
            int age = int.Parse(args[1]);
            string group = args[2];

            rebel = new Rebel(name, age, group);
            return rebel;
        }
    }
}
