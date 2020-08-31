using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender_App.Models;

namespace Bartender_App.ViewModels
{
    public class OrderQueueVM
    {
        public Queue Queue { get; set; }
        public string ReturnUrl { get; set; }
    }
}
