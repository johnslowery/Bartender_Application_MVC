#pragma checksum "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\Queue\PlaceOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1091f6bc9ae47d8087c984494d6aa4d5215a535f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queue_PlaceOrder), @"mvc.1.0.view", @"/Views/Queue/PlaceOrder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\_ViewImports.cshtml"
using Bartender_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\_ViewImports.cshtml"
using Bartender_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\_ViewImports.cshtml"
using Bartender_App.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1091f6bc9ae47d8087c984494d6aa4d5215a535f", @"/Views/Queue/PlaceOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07da00b16fdfd4e704b34d4a8320c04f8edeb502", @"/Views/_ViewImports.cshtml")]
    public class Views_Queue_PlaceOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cocktail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\Queue\PlaceOrder.cshtml"
  
    ViewData["Title"] = "Place an Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Place an Order</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\Queue\PlaceOrder.cshtml"
 foreach (var p in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\Queue\PlaceOrder.cshtml"
Write(Html.Partial("CocktailIndividual", p));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jack\source\repos\Bartender_App\Bartender_App\Views\Queue\PlaceOrder.cshtml"
                                          
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cocktail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
