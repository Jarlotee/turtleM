using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turtleM.Ninject;
using turtleM.Tests.Lunch;
using Xunit;

namespace turtleM.Tests.Ninject
{
    /// <summary>
    /// Tests async mediator methods and named dependency resolution
    /// </summary>
    public class NinjectLunchTests : LunchTests
    {
        IKernel _kernal;

        public NinjectLunchTests()
        {
            // Register components
            _kernal = new StandardKernel();

            // Register turtleM components
            _kernal.Bind<IDependencyInjector>().To<NinjectDependencyInjector>();
            _kernal.Bind<IMediator>().To<Mediator>();

            // Register test handlers
            _kernal.Bind<IAsyncRequestHandler<Ingredients, Entree>>().To<IngredientsEntreeWrapHandler>().Named("wrap");
            _kernal.Bind<IAsyncRequestHandler<Ingredients, Entree>>().To<IngredientsEntreeSandwichHandler>().Named("sandwich");

            // Handle initial resolve
            _mediator = _kernal.Get<IMediator>();
        }
    }
}
