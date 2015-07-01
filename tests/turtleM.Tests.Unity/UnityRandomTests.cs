using Microsoft.Practices.Unity;
using turtleM.Tests.Random;
using turtleM.Unity;

namespace turtleM.Tests.Unity
{
    public class UnityRandomTests : RandomTests
    {
        IUnityContainer _container;

        public UnityRandomTests()
        {
            // Register components
            _container = new UnityContainer();

            // Register turtleM components
            _container.RegisterType<IDependencyInjector, UnityDependencyInjector>(); //Default is singleton
            _container.RegisterType<IMediator, Mediator>();

            // Register test handlers
            _container.RegisterType<IAsyncHandler<int>, AsyncIntHandler>();
            _container.RegisterType<IHandler<double>, DoubleNegativeHandler>("negative");
            _container.RegisterType<IHandler<double>, DoublePositiveHandler>("positive");

            // Handle initial resolve
            _mediator = _container.Resolve<IMediator>();
        }
    }
}
