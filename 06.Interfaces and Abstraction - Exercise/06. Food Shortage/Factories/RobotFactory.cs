namespace BorderControl.Factories
{
    public class RobotFactory
    {
        public IRobot GetRobot(string[] args)
        {
            IRobot robot = null;

            string model = args[1];
            string id = args[2];

            robot = new Robot(model, id);
            return robot;
        }
    }
}
