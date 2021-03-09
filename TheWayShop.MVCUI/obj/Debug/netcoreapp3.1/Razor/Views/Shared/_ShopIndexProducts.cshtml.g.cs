#pragma checksum "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fff854a59399e3094e5b63df8b93083bd65cc680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShopIndexProducts), @"mvc.1.0.view", @"/Views/Shared/_ShopIndexProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff854a59399e3094e5b63df8b93083bd65cc680", @"/Views/Shared/_ShopIndexProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579d9053234c9fec8a734b7dc75b9d19f86c15b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShopIndexProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div role=\"tabpanel\" class=\"tab-pane fade show active\" id=\"grid-view\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-6 col-md-6 col-lg-4 col-xl-4"">
                <div class=""products-single fix"">
                    <div class=""box-img-hover"">
                        <div class=""type-lb"">
                            <p class=""sale"">Sale</p>
                        </div>
                        <img");
            BeginWriteAttribute("src", " src=\"", 497, "\"", 568, 1);
#nullable restore
#line 14 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
WriteAttributeValue("", 503, product.ProductPhotos.SingleOrDefault(x=>x.IsCoverPhoto).Photo, 503, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Image\" style=\"height:220px;\">\r\n                        <div class=\"mask-icon\">\r\n                            <ul>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 745, "\"", 834, 2);
            WriteAttributeValue("", 752, "/", 752, 1, true);
#nullable restore
#line 17 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
WriteAttributeValue("", 753, StringManipulator.GetSeoFriendlyString(product.ProductName) + "-" + product.Id, 753, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""tooltip"" data-placement=""right"" title=""Görüntüle""><i class=""fas fa-eye""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Karşılaştır""><i class=""fas fa-sync-alt""></i></a></li>
                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""İstek Listesine Ekle""><i class=""far fa-heart""></i></a></li>
                            </ul>
                            <a class=""cart"" href=""#"">Sepete Ekle</a>
                        </div>
                    </div>
                    <div class=""why-text"">
                        <h4>");
#nullable restore
#line 25 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h5>");
#nullable restore
#line 26 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                        Write(product.DiscountRate.HasValue ? ((1 - (product.DiscountRate.Value / 100.0M)) * product.Price.Value).ToString("N2") : product.Price.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div role=\"tabpanel\" class=\"tab-pane fade\" id=\"list-view\">\r\n");
#nullable restore
#line 36 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""list-view-box"">
            <div class=""row"">
                <div class=""col-sm-6 col-md-6 col-lg-4 col-xl-4"">
                    <div class=""products-single fix"">
                        <div class=""box-img-hover"">
                            <div class=""type-lb"">
                                <p class=""new"">New</p>
                            </div>
                            <img");
            BeginWriteAttribute("src", " src=\"", 2337, "\"", 2408, 1);
#nullable restore
#line 46 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
WriteAttributeValue("", 2343, product.ProductPhotos.SingleOrDefault(x=>x.IsCoverPhoto).Photo, 2343, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Image\" style=\"height:220px;\">\r\n                            <div class=\"mask-icon\">\r\n                                <ul>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2597, "\"", 2686, 2);
            WriteAttributeValue("", 2604, "/", 2604, 1, true);
#nullable restore
#line 49 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
WriteAttributeValue("", 2605, StringManipulator.GetSeoFriendlyString(product.ProductName) + "-" + product.Id, 2605, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""tooltip"" data-placement=""right"" title=""Görüntüle""><i class=""fas fa-eye""></i></a></li>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                </ul>

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-6 col-lg-8 col-xl-8"">
                    <div class=""why-text full-width"">
                        <h4>");
#nullable restore
#line 60 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("                        <h5>\r\n");
#nullable restore
#line 63 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                             if (product.DiscountRate.HasValue)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <del>");
#nullable restore
#line 65 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                                Write(product.Price.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</del>\r\n                                <span>");
#nullable restore
#line 66 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                                  Write(((1 - (product.DiscountRate / 100.0M)) * product.Price).Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</span>\r\n");
#nullable restore
#line 67 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 71 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                                 Write(product.Price.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</span>\r\n");
#nullable restore
#line 72 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </h5>\r\n                        <p>\r\n                            ");
#nullable restore
#line 75 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
                       Write(product.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <a class=\"btn hvr-hover\" href=\"#\">Sepete Ekle</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 82 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shared\_ShopIndexProducts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591