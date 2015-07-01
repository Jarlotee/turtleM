using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turtleM.Tests.Lunch;
using turtleM.Unity;
using Xunit;

namespace turtleM.Tests.Unity
{
    /// <summary>
    /// Tests async mediator methods and named dependency resolution
    /// </summary>
    public class UnityLunchTests :  LunchTests
    {
        IUnityContainer _container;
        
        public UnityLunchTests()
        {
            // Register components
            _container = new UnityContainer();

            // Register turtleM components
            _container.RegisterType<IDependencyInjector, UnityDependencyInjector>(); //Default is singleton
            _container.RegisterType<IMediator, Mediator>();

            // Register test handlers
            _container.RegisterType<IAsyncRequestHandler<Ingredients, Entree>, AsyncIngredientsEntreeWrapHandler>("wrap");
            _container.RegisterType<IAsyncRequestHandler<Ingredients, Entree>, AsyncIngredientsEntreeSandwichHandler>("sandwich");

            // Handle initial resolve
            _mediator = _container.Resolve<IMediator>();
        }
    }
}
