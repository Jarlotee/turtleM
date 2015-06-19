using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtleM.Tests.Lunch
{
    public class IngredientsEntreeWrapHandler : IAsyncRequestHandler<Ingredients, Entree>
    {
        public async Task<Entree> HandleAsync(Ingredients request)
        {
            var result = new Entree
            {
                Description = string.Format("Low calorie {0} and {1} wrap.", request.Protein, request.Vegetable)
            };

            return await Task.FromResult(result);
        }
    }
}
