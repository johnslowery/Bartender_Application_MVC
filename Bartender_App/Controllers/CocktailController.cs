using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bartender_App.Controllers
{
    public class CocktailController : Controller
    {
        private ICocktailRepository repository;

        public CocktailController(ICocktailRepository repo)
        {
            repository = repo;
        }
    }
}
