#pragma checksum "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e06ad0322542dac3a8c4330ff180aeebc64ddb40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_IndexPageSlider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/IndexPageSlider/Default.cshtml")]
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
#line 1 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\_ViewImports.cshtml"
using TheWayShop.MVCUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\_ViewImports.cshtml"
using TheWayShop.MVCUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\_ViewImports.cshtml"
using TheWayShop.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\_ViewImports.cshtml"
using TheWayShop.Model.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\_ViewImports.cshtml"
using TheWayShop.MVCUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\_ViewImports.cshtml"
using Core.Utilities.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06ad0322542dac3a8c4330ff180aeebc64ddb40", @"/Views/Shared/Components/IndexPageSlider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579d9053234c9fec8a734b7dc75b9d19f86c15b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_IndexPageSlider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"slides-shop\" class=\"cover-slides\">\r\n    <ul class=\"slides-container\">\r\n");
#nullable restore
#line 5 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
         foreach (var slider in Model)
        {
            if (slider.IsActive != false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"text-center\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 279, "\"", 304, 1);
#nullable restore
#line 10 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
WriteAttributeValue("", 285, slider.SliderImage, 285, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 305, "\"", 325, 1);
#nullable restore
#line 10 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
WriteAttributeValue("", 311, slider.Header, 311, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"container\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-12\">\r\n                                <h1 class=\"m-b-20\"><strong>");
#nullable restore
#line 14 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
                                                      Write(slider.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h1>\r\n                                <p class=\"m-b-40\">");
#nullable restore
#line 15 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
                                             Write(slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
                                 if (!string.IsNullOrEmpty(slider.Link))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p><a class=\"btn hvr-hover\"");
            BeginWriteAttribute("href", " href=\"", 806, "\"", 825, 1);
#nullable restore
#line 18 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
WriteAttributeValue("", 813, slider.Link, 813, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">TIKLA</a></p>\r\n");
#nullable restore
#line 19 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 25 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\Components\IndexPageSlider\Default.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n    <div class=\"slides-navigation\">\r\n        <a href=\"#\" class=\"next\"><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i></a>\r\n        <a href=\"#\" class=\"prev\"><i class=\"fa fa-angle-left\" aria-hidden=\"true\"></i></a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591