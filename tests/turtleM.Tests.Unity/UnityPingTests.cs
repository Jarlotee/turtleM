using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turtleM.Tests.PingPong;
using turtleM.Unity;
using Xunit;

namespace turtleM.Tests.Unity
{
    public class UnityPingTests : PingTests
    {
        IUnityContainer _container;

        public UnityPingTests()
        {
            // Register components
            _container = new UnityContainer();

            // Register turtleM components
            _container.RegisterType<IDependencyInjector, UnityDependencyInjector>(); //Default is singleton
            _container.RegisterType<IMediator, Mediator>();

            // Register test handlers
            _container.RegisterType<IRequestHandler<Ping, string>, PingStringHandler>();
            _container.RegisterType<IRequestHandler<Ping, Pong>, PingPongHandler>();

            // Handle initial resolve
            _mediator = _container.Resolve<IMediator>();
        }
    }
}
