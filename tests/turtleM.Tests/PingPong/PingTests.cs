using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace turtleM.Tests.PingPong
{
    public abstract class PingTests
    {
        protected IMediator _mediator;

        [Fact]
        public void CanGetPongString()
        {
            var result = _mediator.Get<Ping, string>(new Ping());

            Assert.Equal("Pong", result);
        }

        [Fact]
        public void CanGetPongObject()
        {
            var result = _mediator.Get<Ping, Pong>(new Ping());

            Assert.Equal("Pong Object", result.Message);
        }
    }
}
