using System.Threading.Tasks;

namespace turtleM
{
    public interface IMediator
    {
        TResult Get<TRequest, TResult>(TRequest request);

        TResult Get<TRequest, TResult>(TRequest request, string name);

        Task<TResult> GetAsync<TRequest, TResult>(TRequest request);

        Task<TResult> GetAsync<TRequest, TResult>(TRequest request, string name);
    }
}
