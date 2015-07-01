using System.Threading.Tasks;

namespace turtleM.Tests.Random
{
    public class AsyncIntHandler : IAsyncHandler<int>
    {
        private System.Random _generator;

        public AsyncIntHandler()
        {
            _generator = new System.Random();
        }

        public Task<int> HandleAsync()
        {
            return Task.FromResult(_generator.Next());
        }
    }
}
