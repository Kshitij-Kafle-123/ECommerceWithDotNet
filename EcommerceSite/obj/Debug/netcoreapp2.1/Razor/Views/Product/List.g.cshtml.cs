#pragma checksum "G:\EcommerceProject\EcommerceSite\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "973ec6bfefb0c38abffb99593f2969d6a709f393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973ec6bfefb0c38abffb99593f2969d6a709f393", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a8c3e0e676e7642488c97c653608f4de37da7b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceSite.Data.ViewModel.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 86, true);
            WriteLiteral("    <!-- Title Page -->\r\n    <section class=\"bg-title-page p-t-50 p-b-40 flex-col-c-m\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 144, "\"", 211, 3);
            WriteAttributeValue("", 152, "background-image:", 152, 17, true);
            WriteAttributeValue(" ", 169, "url(", 170, 5, true);
#line 3 "G:\EcommerceProject\EcommerceSite\Views\Product\List.cshtml"
WriteAttributeValue("", 174, Url.Content("~/images/product1.jpg"), 174, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(212, 689, true);
            WriteLiteral(@">
        <h2 class=""l-text2 t-center"">
            Fashion Sale
        </h2>
        <p class=""m-text13 t-center"">
            Exercise your rights to fashion
        </p>
    </section>
    <!-- Content page -->
    <section class=""bgwhite p-t-55 p-b-65"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-6 col-md-4 col-lg-3 p-b-50"">
                    <div class=""leftbar p-r-20 p-r-0-sm"">
                        <!--  -->
                        <h4 class=""m-text14 p-b-7"">
                            Categories
                        </h4>
                        <ul class=""p-b-54"">
                            ");
            EndContext();
            BeginContext(902, 43, false);
#line 22 "G:\EcommerceProject\EcommerceSite\Views\Product\List.cshtml"
                       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(945, 142, true);
            WriteLiteral("\r\n                        </ul>\r\n                        <div class=\"search-product pos-relative bo4 of-hidden\">\r\n                            ");
            EndContext();
            BeginContext(1087, 298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b16bc776477549ebbfd416f74f937fb9", async() => {
                BeginContext(1172, 108, true);
                WriteLiteral("\r\n                                <input class=\"s-text7 size6 p-l-23 p-r-50\" type=\"text\" name=\"searchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1280, "\"", 1313, 1);
#line 26 "G:\EcommerceProject\EcommerceSite\Views\Product\List.cshtml"
WriteAttributeValue("", 1288, ViewData["searchString"], 1288, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1314, 64, true);
                WriteLiteral(" placeholder=\"Search Products...\">\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1385, 372, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>

                <div class=""col-sm-6 col-md-8 col-lg-9 p-b-50"">
                     <div class=""sec-title p-b-60"">
                          <h3 class=""m-text5 t-center"">
                            Our Products
                          </h3>
                      </div>


");
            EndContext();
#line 40 "G:\EcommerceProject\EcommerceSite\Views\Product\List.cshtml"
                 foreach (var product in Model.Products)
                {
                    

#line default
#line hidden
            BeginContext(1855, 48, false);
#line 42 "G:\EcommerceProject\EcommerceSite\Views\Product\List.cshtml"
               Write(await Html.PartialAsync("_productList", product));

#line default
#line hidden
            EndContext();
#line 42 "G:\EcommerceProject\EcommerceSite\Views\Product\List.cshtml"
                                                                     ;
                }

#line default
#line hidden
            BeginContext(1925, 436, true);
            WriteLiteral(@"                <!-- Product -->
                    <!-- Pagination -->
                    <div class=""pagination flex-m flex-w p-t-26"">
                        <a href=""#"" class=""item-pagination flex-c-m trans-0-4 active-pagination"">1</a>
                        <a href=""#"" class=""item-pagination flex-c-m trans-0-4"">2</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommerceSite.Data.ViewModel.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
