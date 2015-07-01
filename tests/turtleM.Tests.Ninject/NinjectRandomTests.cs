using Ninject;
using turtleM.Ninject;
using turtleM.Tests.Random;

namespace turtleM.Tests.Ninject
{
    public class NinjectRandomTests : RandomTests
    {
        IKernel _kernal;

        public NinjectRandomTests()
        {
            // Register components
            _kernal = new StandardKernel();

            // Register turtleM components
            _kernal.Bind<IDependencyInjector>().To<NinjectDependencyInjector>();
            _kernal.Bind<IMediator>().To<Mediator>();

            // Register test handlers
            _kernal.Bind<IAsyncHandler<int>>().To<AsyncIntHandler>();
            _kernal.Bind<IHandler<double>>().To<DoubleNegativeHandler>().Named("negative");
            _kernal.Bind<IHandler<double>>().To<DoublePositiveHandler>().Named("positive");

            // Handle initial resolve
            _mediator = _kernal.Get<IMediator>();
        }
    }
}
