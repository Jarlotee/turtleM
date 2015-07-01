using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM
{
    public interface IAsyncHandler<TResult>
    {
        Task<TResult> HandleAsync();
    }
}
