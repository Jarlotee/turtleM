using System.Threading.Tasks;
using Xunit;

namespace turtleM.Tests.Random
{
    public abstract class RandomTests
    {
        protected IMediator _mediator;

        [Fact]
        public async Task CanGetRandomIntAsync()
        {
            var result = await _mediator.GetAsync<int>();

            Assert.True(result >= 0);
        }

        [Fact]
        public void CanGetPositiveDouble()
        {
            var result = _mediator.Get<double>("positive");

            Assert.True(result >= 0);
        }

        [Fact]
        public void CanGetNegativeDouble()
        {
            var result = _mediator.Get<double>("negative");

            Assert.True(result <= 0);
        }
    }
}
