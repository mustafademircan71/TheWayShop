#pragma checksum "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07e0cb7d4be8a15363e09ca48104728becaca28c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Product_ProductDeatilsAndUpdate), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Product/ProductDeatilsAndUpdate.cshtml")]
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
#line 1 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using TheWayShop.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using TheWayShop.Model.ViewModels.AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using TheWayShop.Model.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07e0cb7d4be8a15363e09ca48104728becaca28c", @"/Areas/AdminPanel/Views/Product/ProductDeatilsAndUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc7c594ee236f7e647553055950af91e9ab37cc", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Product_ProductDeatilsAndUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlCategoryListUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ddlCategoryListUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlBradnListUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ddlBradnListUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmUpdateProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-12 form-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert2/dist/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/summernote/summernote-bs4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminPanel/js/NewProduct.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert2/dist/sweetalert2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/summernote/summernote-bs4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
  
    ViewData["Title"] = "ProductDeatilsAndUpdate";
    Layout = "~/Areas/AdminPanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e0cb7d4be8a15363e09ca48104728becaca28c9369", async() => {
                WriteLiteral("\r\n    <input id=\"hfProductIdUpdate\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 259, "\"", 276, 1);
#nullable restore
#line 10 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
WriteAttributeValue("", 267, Model.Id, 267, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  />\r\n    <div class=\"form-group col-md-4 \" >\r\n        <label class=\"form-label\">Ürün Adı</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"txtProductNameUpdate\" name=\"txtProductNameUpdate\" placeholder=\"Ürün Adı\"");
                BeginWriteAttribute("value", " value=\"", 500, "\"", 526, 1);
#nullable restore
#line 13 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
WriteAttributeValue("", 508, Model.ProductName, 508, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <label class=\"form-label\">Fiyat</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"txtPriceUpdate\" name=\"txtPriceUpdate\" placeholder=\"Fiyat\"");
                BeginWriteAttribute("value", " value=\"", 731, "\"", 751, 1);
#nullable restore
#line 17 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
WriteAttributeValue("", 739, Model.Price, 739, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <br /> <br />\r\n    <div class=\"col-md-4\">\r\n        <label class=\"form-label\">İndirim Oranı</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"txtDiscountUpdate\" name=\"txtDiscountUpdate\" placeholder=\"İndirim Oranı\"");
                BeginWriteAttribute("value", " value=\"", 995, "\"", 1018, 1);
#nullable restore
#line 22 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
WriteAttributeValue("", 1003, Model.Discount, 1003, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("   />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <label class=\"form-label\">Stok Miktarı</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"txtStockUpdate\" name=\"txtStockUpdate\" placeholder=\"Stok Miktarı\"");
                BeginWriteAttribute("value", " value=\"", 1238, "\"", 1258, 1);
#nullable restore
#line 26 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
WriteAttributeValue("", 1246, Model.Stock, 1246, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  >\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <label for=\"inputState\">Kategorisi</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e0cb7d4be8a15363e09ca48104728becaca28c12824", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 30 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Cateogries;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <label for=\"inputState\">Marka</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e0cb7d4be8a15363e09ca48104728becaca28c14835", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 35 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Brands;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
    <div class="" col-md-4"">
        <label>Fotoğraflar</label>
        <input id=""fuPhotoUpdate"" name=""fuPhotoUpdate"" type=""file"" class=""form-control"" multiple />
    </div>
    <div class=""col-md-12"">
        <label>Kısa Açıklama</label>
        <textarea id=""txtShortDescriptionUpdate"" class=""form-control"" >");
#nullable restore
#line 44 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
                                                                  Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n    </div>\r\n    <div class=\" col-md-12\">\r\n        <label>Açıklama</label>\r\n        <textarea id=\"txtDescriptionUpdate\" class=\"form-control\">");
#nullable restore
#line 48 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
                                                            Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"form-check\">\r\n            <input class=\"form-check-input\" type=\"checkbox\" id=\"gridCheckActiveUpdate\" name=\"gridCheckActiveUpdate\" checked");
                BeginWriteAttribute("value", " value=\"", 2457, "\"", 2480, 1);
#nullable restore
#line 52 "C:\Users\mustafa\Desktop\TheWayShop\TheWayShop.MVCUI\Areas\AdminPanel\Views\Product\ProductDeatilsAndUpdate.cshtml"
WriteAttributeValue("", 2465, Model.IsActive, 2465, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" >
            <label class=""form-check-label"" for=""gridCheckActive"">
                Aktif
            </label>
        </div>
    </div>
    <br /><br />
    <div class=""col-3"">
        <button id=""btnSaveUpdate"" type=""button"" class=""btn btn-primary"">Kaydet</button>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e0cb7d4be8a15363e09ca48104728becaca28c20087", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e0cb7d4be8a15363e09ca48104728becaca28c21187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e0cb7d4be8a15363e09ca48104728becaca28c22287", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e0cb7d4be8a15363e09ca48104728becaca28c23387", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07e0cb7d4be8a15363e09ca48104728becaca28c24647", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07e0cb7d4be8a15363e09ca48104728becaca28c25828", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n        .error {\r\n            color: red;\r\n        }\r\n    </style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsVm> Html { get; private set; }
    }
}
#pragma warning restore 1591