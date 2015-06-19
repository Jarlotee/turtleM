using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM
{
    public interface IRequestHandler<in TRequest, out TResult>
    {
        TResult Handle(TRequest request);
    }
}
