using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM
{
    public class Mediator : IMediator
    {
        IDependencyInjector _injector;

        public Mediator(IDependencyInjector injector)
        {
            _injector = injector;
        }

        public TResult Get<TRequest, TResult>(TRequest request)
        {
            var handler = _injector.Get<IRequestHandler<TRequest, TResult>>();

            return handler.Handle(request);
        }

        public TResult Get<TRequest, TResult>(TRequest request, string name)
        {
            var handler = _injector.Get<IRequestHandler<TRequest, TResult>>(name);

            return handler.Handle(request);
        }

        public async Task<TResult> GetAsync<TRequest, TResult>(TRequest request)
        {
            var handler = _injector.Get<IAsyncRequestHandler<TRequest, TResult>>();

            return await handler.HandleAsync(request);
        }

        public async Task<TResult> GetAsync<TRequest, TResult>(TRequest request, string name)
        {
            var handler = _injector.Get<IAsyncRequestHandler<TRequest, TResult>>(name);

            return await handler.HandleAsync(request);
        }
    }
}
