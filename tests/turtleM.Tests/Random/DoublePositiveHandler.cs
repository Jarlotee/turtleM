namespace turtleM.Tests.Random
{
    public class DoublePositiveHandler: IHandler<double>
    {
        private System.Random _generator;

        public DoublePositiveHandler()
        {
            _generator = new System.Random();
        }

        public double Handle()
        {
            return _generator.NextDouble();
        }
    }
}
