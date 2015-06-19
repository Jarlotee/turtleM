using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace turtleM.Ninject
{
    public class NinjectDependencyInjector : IDependencyInjector
    {
        IKernel _kernal;

        public NinjectDependencyInjector(IKernel kernal)
        {
            _kernal = kernal;
        }

        public TResult Get<TResult>()
        {
            return _kernal.Get<TResult>();
        }

        public TResult Get<TResult>(string name)
        {
            return _kernal.Get<TResult>(name);
        }
    }
}
