#pragma checksum "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcacec8ab60b0245a9c278d085ac1937a14af4ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_GetDishById), @"mvc.1.0.view", @"/Views/Menu/GetDishById.cshtml")]
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
#line 1 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\_ViewImports.cshtml"
using NS.DigitalMenu.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\_ViewImports.cshtml"
using NS.DigitalMenu.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml"
using NS.DigitalMenuModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcacec8ab60b0245a9c278d085ac1937a14af4ef", @"/Views/Menu/GetDishById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1190a64a2ed2f71ff0d2f86fddd0c36c5378c61", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_GetDishById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""display-4"">Dish Details</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-bs-ride=""carousel"">
  <div class=""carousel-indicators"">
    <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
    <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
    <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
  </div>
  <div class=""carousel-inner"">
    <div class=""carousel-item active"">

      <img");
            BeginWriteAttribute("src", " src=\"", 805, "\"", 811, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"...\">\r\n    </div>\r\n    <div class=\"carousel-item\">\r\n      <img");
            BeginWriteAttribute("src", " src=\"", 902, "\"", 908, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"...\">\r\n    </div>\r\n    <div class=\"carousel-item\">\r\n      <img");
            BeginWriteAttribute("src", " src=\"", 999, "\"", 1005, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block w-100"" alt=""..."">
    </div>
  </div>
  <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""visually-hidden""></span>
  </button>
  <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""visually-hidden""></span>
  </button>
</div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 39 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml"
                   Write(Model.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span class=\"col-form-label\">Price:</span>\r\n                    <span class=\"monospaced\">");
#nullable restore
#line 46 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml"
                                        Write(Model.DishPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p>");
#nullable restore
#line 52 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml"
                  Write(Model.DishDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-4"">
                    <button class=""btn btn-outline-primary"">
                       Order Now
                    </button>
                </div>
            </div> 

            <hr/>
            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category - </span>");
#nullable restore
#line 67 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml"
                                                                                        Write(Model.DishCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Type - </span>");
#nullable restore
#line 68 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml"
                                                                                    Write(Model.DishType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Quantity- </span>");
#nullable restore
#line 69 "C:\Users\Akshit Dadhwal\Desktop\DigitalMenu\DigitalMenu\NS.DigitalMenu.WEB\Views\Menu\GetDishById.cshtml"
                                                                                       Write(Model.DishQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n           \r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
