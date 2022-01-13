namespace BorderControl.Factories
{
    public class RobotFactory
    {
        public IRobot GetRobot(string[] args)
        {
            IRobot robot = null;

            string model = args[0];
            string id = args[1];

            robot = new Robot(model, id);
            return robot;
        }
    }
}
