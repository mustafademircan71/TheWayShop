#pragma checksum "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee3297526ac072e93520850a32c2189d73dd317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ProductDetails), @"mvc.1.0.view", @"/Views/Shop/ProductDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee3297526ac072e93520850a32c2189d73dd317", @"/Views/Shop/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579d9053234c9fec8a734b7dc75b9d19f86c15b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDetailsVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ViewedProduct.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert2/dist/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert2/dist/sweetalert2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
  
    ViewData["Title"] = "ProductDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";
    User activeUser = Context.Session.GetObject<User>("ActiveUser");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"shop-detail-box-main\">\r\n    <input id=\"hfProductId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 274, "\"", 299, 1);
#nullable restore
#line 12 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 282, Model.Product.Id, 282, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input id=\"hfUserId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 343, "\"", 393, 1);
#nullable restore
#line 13 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 351, activeUser != null ? activeUser.Id : -1, 351, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-5 col-lg-5 col-md-6"">
                <div id=""carousel-example-1"" class=""single-product-slider carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner"" role=""listbox"">
");
#nullable restore
#line 20 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                           int j = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                         foreach (var item in Model.Product.ProductPhotos)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 864, "\"", 907, 2);
            WriteAttributeValue("", 872, "carousel-item", 872, 13, true);
#nullable restore
#line 23 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue(" ", 885, j++==0?"active":"", 886, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 936, "\"", 955, 1);
#nullable restore
#line 23 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 942, item.Photo, 942, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 956, "\"", 962, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:350px;\"> </div>\r\n");
#nullable restore
#line 24 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                    <a class=""carousel-control-prev"" href=""#carousel-example-1"" role=""button"" data-slide=""prev"">
                        <i class=""fa fa-angle-left"" aria-hidden=""true""></i>
                        <span class=""sr-only"">??nceki</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carousel-example-1"" role=""button"" data-slide=""next"">
                        <i class=""fa fa-angle-right"" aria-hidden=""true""></i>
                        <span class=""sr-only"">Sonraki</span>
                    </a>
                    <ol class=""carousel-indicators"">
");
#nullable restore
#line 37 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                           int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                         foreach (var item in Model.Product.ProductPhotos)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li data-target=\"#carousel-example-1\" data-slide-to=\"");
#nullable restore
#line 40 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                                                                             Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 1897, "\"", 1924, 1);
#nullable restore
#line 40 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 1905, i==1?"active":"", 1905, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"d-block w-100 img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1996, "\"", 2013, 1);
#nullable restore
#line 41 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 2002, item.Photo, 2002, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2014, "\"", 2020, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:75px;\" />\r\n                            </li>\r\n");
#nullable restore
#line 43 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ol>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xl-7 col-lg-7 col-md-6\">\r\n                <div class=\"single-product-details\">\r\n                    <input id=\"hfProductIdUpdate\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2353, "\"", 2378, 1);
#nullable restore
#line 50 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 2361, Model.Product.Id, 2361, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h2>");
#nullable restore
#line 51 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                   Write(Model.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5> <del>??? ");
#nullable restore
#line 52 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                           Write(Model.Product.Price.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del> ");
#nullable restore
#line 52 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                                                                            Write(Model.Product.DiscountRate.HasValue ? ((1 - (@Model.Product.DiscountRate.Value / 100.0M)) * @Model.Product.Price.Value).ToString("N2") : @Model.Product.Price.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"available-stock\"><span>Stokta ");
#nullable restore
#line 53 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                                                       Write(Model.Product.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Adet Bulunmaktad??r <a href=\"#\"></a></span>\r\n                    <p>\r\n                        <h4>??r??n K??sa A????klamas??:</h4>\r\n                    <p>\r\n");
#nullable restore
#line 57 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                         if (string.IsNullOrEmpty(Model.Product.ShortDescription))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">??u an bu ??r??n i??in kay??tl?? bir a????klama yok.</div>\r\n");
#nullable restore
#line 60 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                       Write(Model.Product.ShortDescription);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                                                           
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </p>
                    <ul>
                        <li>
                            <div class=""form-group quantity-box"">
                                <label class=""control-label"">Adet</label>
                                <input id=""txtQuantity"" class=""form-control"" value=""0"" min=""0"" max=""20"" type=""number"">
                            </div>
                        </li>
                    </ul>

                    <div class=""price-box-bar"">
                        <div class=""cart-and-bay-btn"">
                            <a class=""btn hvr-hover"" data-fancybox-close="""" href=""#"">Buy New</a>
                            <a id=""btnAddToCart"" class=""btn hvr-hover"" data-fancybox-close="""" style=""color:white;"">Sepete Ekle</a>
                        </div>
                    </div>

                    <div class=""add-to-btn"">
                        <div class=""add-comp"">
                            <a class=""btn hvr-hover"" href=""#""><i class=""fas fa-heart""></i> Ad");
            WriteLiteral(@"d to wishlist</a>
                            <a class=""btn hvr-hover"" href=""#""><i class=""fas fa-sync-alt""></i> Add to Compare</a>
                        </div>
                        <div class=""share-bar"">
                            <a class=""btn hvr-hover"" href=""#""><i class=""fab fa-facebook"" aria-hidden=""true""></i></a>
                            <a class=""btn hvr-hover"" href=""#""><i class=""fab fa-google-plus"" aria-hidden=""true""></i></a>
                            <a class=""btn hvr-hover"" href=""#""><i class=""fab fa-twitter"" aria-hidden=""true""></i></a>
                            <a class=""btn hvr-hover"" href=""#""><i class=""fab fa-pinterest-p"" aria-hidden=""true""></i></a>
                            <a class=""btn hvr-hover"" href=""#""><i class=""fab fa-whatsapp"" aria-hidden=""true""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row my-5"">
            <div class=""col-lg-12"">
                <div cla");
            WriteLiteral("ss=\"title-all text-center\">\r\n                    <h1>A????klama</h1>\r\n                    <div>\r\n                        ");
#nullable restore
#line 104 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Views\Shop\ProductDetails.cshtml"
                   Write(Html.Raw(@Model.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>


                </div>
                <div class=""featured-products-box owl-carousel owl-theme"">
                    <div class=""item"">
                        <div class=""products-single fix"">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-01.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
                                    <ul>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                    </ul>
                     ");
            WriteLiteral(@"               <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
                                <h4>Lorem ipsum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""products-single fix"">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-02.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
                                    <ul>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i cl");
            WriteLiteral(@"ass=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                    </ul>
                                    <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
                                <h4>Lorem ipsum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""products-single fix"">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-03.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
                                    <ul>
        ");
            WriteLiteral(@"                                <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                    </ul>
                                    <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
                                <h4>Lorem ipsum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""products-single fix");
            WriteLiteral(@""">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-04.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
                                    <ul>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                    </ul>
                                    <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
                                <h4>Lorem ip");
            WriteLiteral(@"sum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""products-single fix"">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-01.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
                                    <ul>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                            ");
            WriteLiteral(@"        </ul>
                                    <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
                                <h4>Lorem ipsum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""products-single fix"">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-02.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
                                    <ul>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-pla");
            WriteLiteral(@"cement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                    </ul>
                                    <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
                                <h4>Lorem ipsum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""products-single fix"">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-03.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
              ");
            WriteLiteral(@"                      <ul>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                    </ul>
                                    <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
                                <h4>Lorem ipsum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                   ");
            WriteLiteral(@"     <div class=""products-single fix"">
                            <div class=""box-img-hover"">
                                <img src=""images/img-pro-04.jpg"" class=""img-fluid"" alt=""Image"">
                                <div class=""mask-icon"">
                                    <ul>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                        <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                    </ul>
                                    <a class=""cart"" href=""#"">Add to Cart</a>
                                </div>
                            </div>
                            <div class=""why-text"">
        ");
            WriteLiteral(@"                        <h4>Lorem ipsum dolor sit amet</h4>
                                <h5> $9.79</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ee3297526ac072e93520850a32c2189d73dd31729110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ee3297526ac072e93520850a32c2189d73dd31730210", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ee3297526ac072e93520850a32c2189d73dd31731434", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopDetailsVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
