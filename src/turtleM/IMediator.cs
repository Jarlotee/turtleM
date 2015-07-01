using System.Threading.Tasks;

namespace turtleM
{
    public interface IMediator
    {
        /// <summary>
        /// Gets the result for the <see cref="IHandler"/> that matches the provide type parameters
        /// </summary>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <returns>The result of executing the <see cref="IHandler"/></returns>
        TResult Get<TResult>();

        /// <summary>
        /// Gets the result for the <see cref="IHandler"/> that matches the provide type parameters and name identifier
        /// </summary>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <param name="name">The name used to register the <see cref="IHandler"/></param>
        /// <returns></returns>
        TResult Get<TResult>(string name);

        /// <summary>
        /// Gets the result for the <see cref="IRequestHandler"/> that matches the provide type parameters
        /// </summary>
        /// <typeparam name="TRequest">The type of request being provided</typeparam>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <param name="request">An instance of the request type</param>
        /// <returns>The result of executing the <see cref="IRequestHandler"/></returns>
        TResult Get<TRequest, TResult>(TRequest request);

        /// <summary>
        /// Gets the result for the <see cref="IRequestHandler"/> that matches the provide type parameters and name identifier
        /// </summary>
        /// <typeparam name="TRequest">The type of request being provided</typeparam>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <param name="request">An instance of the request type</param>
        /// <param name="name">The name used to register the <see cref="IRequestHandler"/></param>
        /// <returns>The result of executing the <see cref="IRequestHandler"/></returns>
        TResult Get<TRequest, TResult>(TRequest request, string name);

        /// <summary>
        /// Gets the result for the <see cref="IAsyncHandler"/> that matches the provide type parameters
        /// </summary>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <returns>The result of executing the <see cref="IAsyncHandler"/></returns>
        Task<TResult> GetAsync<TResult>();

        /// <summary>
        /// Gets the result for the <see cref="IAsyncHandler"/> that matches the provide type parameters and name identifier
        /// </summary>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <param name="name">The name used to register the <see cref="IAsyncHandler"/></param>
        /// <returns>The result of executing the <see cref="IAsyncHandler"/></returns>
        Task<TResult> GetAsync<TResult>(string name);

        /// <summary>
        /// Gets the result for the <see cref="IAsyncRequestHandler"/> that matches the provide type parameters
        /// </summary>
        /// <typeparam name="TRequest">The type of request being provided</typeparam>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <param name="request">An instance of the request type</param>
        /// <returns>The result of executing the <see cref="IAsyncRequestHandler"/></returns>
        Task<TResult> GetAsync<TRequest, TResult>(TRequest request);

        /// <summary>
        /// Gets the result for the <see cref="IAsyncRequestHandler"/> that matches the provide type parameters and name identifier 
        /// </summary>
        /// <typeparam name="TRequest">The type of request being provided</typeparam>
        /// <typeparam name="TResult">The type of result required</typeparam>
        /// <param name="request">An instance of the request type</param>
        /// <param name="name">The name used to register the <see cref="IAsyncRequestHandler"/></param>
        /// <returns>The result of executing the <see cref="IAsyncRequestHandler"/></returns>
        Task<TResult> GetAsync<TRequest, TResult>(TRequest request, string name);
    }
}
