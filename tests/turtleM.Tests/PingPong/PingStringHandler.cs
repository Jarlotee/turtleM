using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM.Tests.PingPong
{
    public class PingStringHandler : IRequestHandler<Ping, string>
    {
        public string Handle(Ping request)
        {
            return "Pong";
        }
    }
}
