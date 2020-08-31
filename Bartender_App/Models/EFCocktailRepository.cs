using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender_App.Models
{
    public class EFCocktailRepository : ICocktailRepository
    {
        private AppDbContext context;
        public EFCocktailRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Cocktail> Cocktails => context.Cocktails;
    }
}
