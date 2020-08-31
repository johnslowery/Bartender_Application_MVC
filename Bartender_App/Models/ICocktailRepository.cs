using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender_App.Models
{
    public interface ICocktailRepository
    {
        IEnumerable<Cocktail> Cocktails { get; }
    }
}
