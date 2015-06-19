using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turtleM.Ninject;
using turtleM.Tests.PingPong;
using Xunit;

namespace turtleM.Tests.Ninject
{
    public class NinjectPingTests : PingTests
    {
        IKernel _kernal;

        public NinjectPingTests()
        {
            // Register components
            _kernal = new StandardKernel();

            // Register turtleM components
            _kernal.Bind<IDependencyInjector>().To<NinjectDependencyInjector>();
            _kernal.Bind<IMediator>().To<Mediator>();

            // Register test handlers
            _kernal.Bind<IRequestHandler<Ping, string>>().To<PingStringHandler>();
            _kernal.Bind<IRequestHandler<Ping, Pong>>().To<PingPongHandler>();

            // Handle initial resolve
            _mediator = _kernal.Get<IMediator>();
        }
    }
}
