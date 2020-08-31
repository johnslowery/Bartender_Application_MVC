using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender_App.Models
{
    public class UserTypeModel
    {
        [BindProperty, Required]
        public string UserType { get; set; }
        public string[] UserTypes = new[] { "Customer", "Staff" };
    }
}
