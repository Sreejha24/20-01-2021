#pragma checksum "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1953feeeb290c795769771bd9f325134f7f90ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Shop), @"mvc.1.0.view", @"/Views/Products/Shop.cshtml")]
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
#line 1 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1953feeeb290c795769771bd9f325134f7f90ab2", @"/Views/Products/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingCart.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;width:250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Products/AddToCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:burlywood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1953feeeb290c795769771bd9f325134f7f90ab27334", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1953feeeb290c795769771bd9f325134f7f90ab27596", async() => {
                    WriteLiteral("\r\n        <p>\r\n            <input type=\"search\" placeholder=\"Enter name or email!!\"");
                    BeginWriteAttribute("value", " value=\"", 258, "\"", 296, 1);
#nullable restore
#line 9 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
WriteAttributeValue("", 266, ViewData["GetProductDetails"], 266, 30, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"ProductSearch\" style=\"width:500px;\" />\r\n            <input type=\"submit\" value=\"search\" class=\"btn btn-primary\" />|\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1953feeeb290c795769771bd9f325134f7f90ab28492", async() => {
                        WriteLiteral("Get all Product details");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        </p>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <h1>Shop</h1>\r\n\r\n\r\n    <table class=\"table\">\r\n");
#nullable restore
#line 18 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    <h4>\r\n                        ");
#nullable restore
#line 24 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h4>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1953feeeb290c795769771bd9f325134f7f90ab212057", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 874, "~/Images/", 874, 9, true);
#nullable restore
#line 26 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
AddHtmlAttributeValue("", 883, item.FileImage, 883, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
AddHtmlAttributeValue("", 905, item.ProductName, 905, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n                <td>Available Discount : 10%</td>\r\n                <td>\r\n                    <div class=\"row\">\r\n                        <div>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1953feeeb290c795769771bd9f325134f7f90ab214346", async() => {
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 33 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                <div class=""form-group"">
                                    <label>
                                        Qty :
                                    </label>
                                    <select name=""Qty"" id=""Qty"" class=""form-control"" onclick=""MyFunction()"">
                                        :
");
#nullable restore
#line 40 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                         for (int i = 1; i <= item.ProductQuantity; i++)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1953feeeb290c795769771bd9f325134f7f90ab215626", async() => {
#nullable restore
#line 42 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                                          Write(i);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                    </select>
                                    <hr />
                                    <p id=""demo""></p>
                                </div>
                                <br />
                                <div class=""form-group"">
                                    <label>
                                        Price :
                                    </label>
                                    ");
#nullable restore
#line 53 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                               Write(item.ProductPrice.ToString("00.00"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(";\r\n                                    <input type=\"hidden\" id=\"prixe\" name=\"Price\"");
                    BeginWriteAttribute("value", " value=\"", 2420, "\"", 2446, 1);
#nullable restore
#line 54 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
WriteAttributeValue("", 2428, item.ProductPrice, 2428, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n");
#nullable restore
#line 57 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                     if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <input type=\"submit\" class=\"btn btn-success\" value=\"Add To Cart\" />\r\n                                        <input type=\"hidden\" name=\"ProductId\"");
                    BeginWriteAttribute("value", " value=\"", 2848, "\"", 2871, 1);
#nullable restore
#line 60 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
WriteAttributeValue("", 2856, item.ProductId, 2856, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n");
#nullable restore
#line 61 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                         if(item.ProductQuantity == 0)
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <p style=\"font-family:\'Times New Roman\', Times, serif;font-weight:300;color:red\">Out of Stock!!!!!</p>\r\n");
#nullable restore
#line 64 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                        <p style=""font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-weight:20px; color:dodgerblue"">
                                            Only

                                            ");
#nullable restore
#line 70 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ProductQuantity));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n                                            Are Left!!!\r\n\r\n\r\n                                        </p>\r\n");
#nullable restore
#line 76 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <a href=\" /Identiy/Account/Login\" class=\"btn btn-warning\">Login to Order</a>\r\n");
#nullable restore
#line 81 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                </div>\r\n\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 89 "D:\SC\ShoppinCart\ShoppingCart\ShoppingCart\Views\Products\Shop.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1953feeeb290c795769771bd9f325134f7f90ab225012", async() => {
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
            WriteLiteral(@"
<script>
    function MyFunction() {
        $.each(){
        var b = $(""#Qty"").val();
        var c = $(""#prixe"").val();
        var a = eval('(10 / 100 )* (c * b)');
            document.getElementById(""demo"").innerHTML = a;
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingCart.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591