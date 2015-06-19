using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM
{
    public interface IDependencyInjector
    {
        TResult Get<TResult>();

        TResult Get<TResult>(string name);
    }
}
