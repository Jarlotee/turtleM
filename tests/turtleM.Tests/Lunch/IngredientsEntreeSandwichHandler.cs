using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM.Tests.Lunch
{
    public class IngredientsEntreeSandwichHandler : IAsyncRequestHandler<Ingredients, Entree>
    {
        public async Task<Entree> HandleAsync(Ingredients request)
        {
            var result = new Entree
            {
                Description = string.Format("Hearty {0} and {1} sandwich.", request.Protein, request.Vegetable)
            };

            return await Task.FromResult(result);
        }
    }
}
