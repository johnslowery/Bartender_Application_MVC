using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bartender_App.Models;
using Bartender_App.ViewModels;
using Bartender_App.Infrastructure;

namespace Bartender_App.Controllers
{
    public class QueueController : Controller
    {
        private ICocktailRepository repository;
        public QueueController(ICocktailRepository repo)
        {
            repository = repo;
        }

        public ViewResult OrderQueue(string returnUrl)
        {
            return View(new OrderQueueVM
            {
                Queue = GetQueue(),
                ReturnUrl = returnUrl
            });
        }

        public ViewResult PlaceOrder() => View(repository.Cocktails);

        public ViewResult Thanks(string returnUrl)
        {
            return View(new OrderQueueVM
            {
                Queue = GetQueue(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToQueue(int cocktailId, string returnUrl)
        {
            Cocktail cocktail = repository.Cocktails
            .FirstOrDefault(p => p.CocktailID == cocktailId);
            if (cocktail != null)
            {
                Queue queue = GetQueue();
                queue.AddItem(cocktail);
                SaveCart(queue);
            }
            return RedirectToAction("Thanks", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromQueue(int cocktailId, string returnUrl)
        {
            Cocktail cocktail = repository.Cocktails
            .FirstOrDefault(p => p.CocktailID == cocktailId);
            if (cocktail != null)
            {
                Queue queue = GetQueue();
                queue.RemoveLine(cocktail);
                SaveCart(queue);
            }
            return RedirectToAction("OrderQueue", new { returnUrl });
        }
        private Queue GetQueue()
        {
            Queue queue = HttpContext.Session.GetJson<Queue>("Queue") ?? new Queue();
            return queue;
        }
        private void SaveCart(Queue queue)
        {
            HttpContext.Session.SetJson("Queue", queue);
        }
    }
}