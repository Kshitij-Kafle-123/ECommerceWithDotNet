#pragma checksum "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2372b82486df2f83f8296502891467fe9a88381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__productFooter), @"mvc.1.0.view", @"/Views/Shared/_productFooter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_productFooter.cshtml", typeof(AspNetCore.Views_Shared__productFooter))]
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
#line 1 "G:\EcommerceProject\EcommerceSite\Views\_ViewImports.cshtml"
using EcommerceSite;

#line default
#line hidden
#line 2 "G:\EcommerceProject\EcommerceSite\Views\_ViewImports.cshtml"
using EcommerceSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2372b82486df2f83f8296502891467fe9a88381", @"/Views/Shared/_productFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a8c3e0e676e7642488c97c653608f4de37da7b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__productFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-c-m size1 bg4 bo-rad-23 hov1 s-text1 trans-0-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml"
  
    var Lst = ViewBag.productList as IEnumerable<EcommerceSite.Data.Model.Product>;

#line default
#line hidden
            BeginContext(92, 237, true);
            WriteLiteral("<section class=\"relateproduct bgwhite p-t-45 p-b-138\">\r\n    <div class=\"container\">\r\n        <div class=\"sec-title p-b-60\">\r\n            <h3 class=\"m-text5 t-center\">\r\n                Related Products\r\n            </h3>\r\n        </div>\r\n");
            EndContext();
#line 11 "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml"
         foreach (var item in Lst)
        {


#line default
#line hidden
            BeginContext(378, 356, true);
            WriteLiteral(@"            <div style=""display:inline-block;"">
                <div style=""display:inline-block;"">
                    <div>
                        <!-- Block2 -->
                        <div class=""block2"">
                            <div class=""block2-img wrap-pic-w of-hidden pos-relative block2-labelnew"">
                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 734, "\"", 764, 1);
#line 20 "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml"
WriteAttributeValue("", 740, Url.Content(item.Image), 740, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(765, 619, true);
            WriteLiteral(@" style="" height:300px;width:330px;"" ;alt=""IMG-PRODUCT"">

                                <div class=""block2-overlay trans-0-4"">
                                    <a href=""#"" class=""block2-btn-addwishlist hov-pointer trans-0-4"">
                                        <i class=""icon-wishlist icon_heart_alt"" aria-hidden=""true""></i>
                                        <i class=""icon-wishlist icon_heart dis-none"" aria-hidden=""true""></i>
                                    </a>
                                    <div class=""block2-btn-addcart w-size1 trans-0-4"">
                                        ");
            EndContext();
            BeginContext(1384, 257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c08f14d1c994d09a2fb1728a48916ae", async() => {
                BeginContext(1538, 99, true);
                WriteLiteral("\r\n                                            Add to Cart\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml"
                                                                                                                                                                     WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1641, 418, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""block2-txt p-t-20"">
                                <a href=""#"" class=""block2-name dis-block s-text3 p-b-5"">
                                    <strong style=""font-size:1.9em;color:cadetblue;font-style:italic;"">
                                        ");
            EndContext();
            BeginContext(2060, 16, false);
#line 37 "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2076, 182, true);
            WriteLiteral("\r\n                                    </strong>\r\n                                </a>\r\n\r\n                                <span class=\"\">\r\n                                    <strong>");
            EndContext();
            BeginContext(2259, 23, false);
#line 42 "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml"
                                       Write(item.Rate.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 192, true);
            WriteLiteral("</strong>\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 49 "G:\EcommerceProject\EcommerceSite\Views\Shared\_productFooter.cshtml"

        }

#line default
#line hidden
            BeginContext(2487, 26, true);
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
