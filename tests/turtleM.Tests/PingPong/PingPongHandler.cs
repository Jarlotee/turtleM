using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM.Tests.PingPong
{
    public class PingPongHandler : IRequestHandler<Ping, Pong>
    {
        public Pong Handle(Ping request)
        {
            return new Pong
            {
                Message = "Pong Object"
            };
        }
    }
}
