using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM
{
    public interface IAsyncRequestHandler<in TRequest, TResult>
    {
        Task<TResult> HandleAsync(TRequest request);
    }
}
