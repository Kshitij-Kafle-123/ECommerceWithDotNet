#pragma checksum "G:\EcommerceProject\EcommerceSite\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85b908c7e0c0aec66ff6bbe70b86ad8784de5dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85b908c7e0c0aec66ff6bbe70b86ad8784de5dc", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a8c3e0e676e7642488c97c653608f4de37da7b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("leave-comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51d095fc434f4ad298e47df08a9e87bd", async() => {
                BeginContext(25, 111, true);
                WriteLiteral("\r\n\r\n    <!-- Header -->\r\n    <!-- Title Page -->\r\n    <section class=\"bg-title-page p-t-40 p-b-50 flex-col-c-m\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 136, "\"", 218, 4);
                WriteAttributeValue("", 144, "background-image:", 144, 17, true);
                WriteAttributeValue(" ", 161, "url(", 162, 5, true);
#line 5 "G:\EcommerceProject\EcommerceSite\Views\Home\Contact.cshtml"
WriteAttributeValue("", 166, Url.Content("~/images/ProductImages/contact.jpg"), 166, 50, false);

#line default
#line hidden
                WriteAttributeValue("", 216, ");", 216, 2, true);
                EndWriteAttribute();
                BeginContext(219, 432, true);
                WriteLiteral(@">
        <h2 class=""l-text2 t-center"">
            Contact
        </h2>
    </section>

    <section class=""bgwhite p-t-66 p-b-60"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 p-b-30"">
                    <div class=""p-r-20 p-r-0-lg"">
                        <div class=""contact-map size21"" id=""google_map"" data-map-x=""40.614439"" data-map-y=""-73.926781"" data-pin=""");
                EndContext();
                BeginContext(652, 45, false);
#line 16 "G:\EcommerceProject\EcommerceSite\Views\Home\Contact.cshtml"
                                                                                                                            Write(Url.Content("~/images/ProductImages/map.jpg"));

#line default
#line hidden
                EndContext();
                BeginContext(697, 171, true);
                WriteLiteral("\" data-scrollwhell=\"0\" data-draggable=\"1\"></div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-md-6 p-b-30\">\r\n                    ");
                EndContext();
                BeginContext(868, 1343, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bbfe3a5414047b4853f44ad8a45ae62", async() => {
                    BeginContext(896, 1308, true);
                    WriteLiteral(@"
                        <h4 class=""m-text26 p-b-36 p-t-15"">
                            Send us your message
                        </h4>

                        <div class=""bo4 of-hidden size15 m-b-20"">
                            <input class=""sizefull s-text7 p-l-22 p-r-22"" type=""text"" name=""name"" placeholder=""Full Name"">
                        </div>

                        <div class=""bo4 of-hidden size15 m-b-20"">
                            <input class=""sizefull s-text7 p-l-22 p-r-22"" type=""text"" name=""phone-number"" placeholder=""Phone Number"">
                        </div>

                        <div class=""bo4 of-hidden size15 m-b-20"">
                            <input class=""sizefull s-text7 p-l-22 p-r-22"" type=""text"" name=""email"" placeholder=""Email Address"">
                        </div>

                        <textarea class=""dis-block s-text7 size20 bo4 p-l-22 p-r-22 p-t-13 m-b-20"" name=""message"" placeholder=""Message""></textarea>

                        <div class=""");
                    WriteLiteral(@"w-size25"">
                            <!-- Button -->
                            <button class=""flex-c-m size2 bg1 bo-rad-23 hov1 m-text3 trans-0-4"">
                                Send
                            </button>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2211, 82, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2300, 4, true);
            WriteLiteral("\r\n\r\n");
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