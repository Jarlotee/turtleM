using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace turtleM.Tests.Lunch
{
    public abstract class LunchTests
    {
        protected IMediator _mediator;

        [Fact]
        public async Task CanGetWrapEntree()
        {
            var ingredients = new Ingredients { Protein = "Ham", Vegetable = "Tomatoe" };

            var result = await _mediator.GetAsync<Ingredients, Entree>(ingredients, "wrap");

            Assert.Equal(result.Description,
                string.Format("Low calorie {0} and {1} wrap.", ingredients.Protein, ingredients.Vegetable));
        }

        [Fact]
        public async Task CanGetSandwichEntree()
        {
            var ingredients = new Ingredients { Protein = "Tofu", Vegetable = "Kale" };

            var result = await _mediator.GetAsync<Ingredients, Entree>(ingredients, "sandwich");

            Assert.Equal(result.Description,
                string.Format("Hearty {0} and {1} sandwich.", ingredients.Protein, ingredients.Vegetable));
        }
    }
}
