namespace turtleM.Tests.Random
{
    public class DoubleNegativeHandler : IHandler<double>
    {
        private System.Random _generator;

        public DoubleNegativeHandler()
        {
            _generator = new System.Random();
        }

        public double Handle()
        {
            return _generator.NextDouble() * -1;
        }
    }
}
