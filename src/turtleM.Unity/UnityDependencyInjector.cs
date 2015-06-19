using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM.Unity
{
    public class UnityDependencyInjector : IDependencyInjector
    {
        IUnityContainer _container;

        public UnityDependencyInjector(IUnityContainer container)
        {
            _container = container;
        }

        public TResult Get<TResult>()
        {
            return _container.Resolve<TResult>();
        }

        public TResult Get<TResult>(string name)
        {
            return _container.Resolve<TResult>(name);
        }
    }
}
