#pragma checksum "D:\Programming\Visual Studio\Backend\WS\WelcomeASP\Views\Home\Pricing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d0fc0f19343b64e302b8b1b8195b1d40e3c9d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pricing), @"mvc.1.0.view", @"/Views/Home/Pricing.cshtml")]
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
#line 1 "D:\Programming\Visual Studio\Backend\WS\WelcomeASP\Views\_ViewImports.cshtml"
using WelcomeASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Visual Studio\Backend\WS\WelcomeASP\Views\_ViewImports.cshtml"
using WelcomeASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5d0fc0f19343b64e302b8b1b8195b1d40e3c9d5", @"/Views/Home/Pricing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45dc71e299098e1240cf823382ed208d6f74ce5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pricing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Asentus/Parallax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\Programming\Visual Studio\Backend\WS\WelcomeASP\Views\Home\Pricing.cshtml"
  
    // данные для вывода в паралаксе
    ViewData["ParallaxTitle"] = "Pricing";
    ViewData["ParallaxText"] = "My price for service";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5d0fc0f19343b64e302b8b1b8195b1d40e3c9d53695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- Pricing -->
<div class=""bg-color-sky-light"">
    <div class=""content-lg container"">
        <div class=""row row-space-1"">
            <div class=""col-sm-4 sm-margin-b-2"">
                <div class=""wow fadeInLeft"" data-wow-duration="".3"" data-wow-delay="".1s"">
                    <!-- Pricing -->
                    <div class=""pricing"">
                        <div class=""margin-b-30"">
                            <i class=""pricing-icon icon-chemistry""></i>
                            <h3>Starter Kit <span> - $</span> 49</h3>
                            <p>Lorem ipsum dolor amet consectetur ut consequat siad esqudiat dolor</p>
                        </div>
                        <ul class=""list-unstyled pricing-list margin-b-50"">
                            <li class=""pricing-list-item"">Basic Features</li>
                            <li class=""pricing-list-item"">Up to 5 products</li>
                            <li class=""pricing-list-item"">50 Users Panels</li>
                        </ul>
         ");
            WriteLiteral(@"               <a href=""pricing.html"" class=""btn-theme btn-theme-sm btn-default-bg text-uppercase"">Choose</a>
                    </div>
                    <!-- End Pricing -->
                </div>
            </div>
            <div class=""col-sm-4 sm-margin-b-2"">
                <div class=""wow fadeInUp"" data-wow-duration="".3"" data-wow-delay="".2s"">
                    <!-- Pricing -->
                    <div class=""pricing pricing-active"">
                        <div class=""margin-b-30"">
                            <i class=""pricing-icon icon-badge""></i>
                            <h3>Professional <span> - $</span> 149</h3>
                            <p>Lorem ipsum dolor amet consectetur ut consequat siad esqudiat dolor</p>
                        </div>
                        <ul class=""list-unstyled pricing-list margin-b-50"">
                            <li class=""pricing-list-item"">Basic Features</li>
                            <li class=""pricing-list-item"">Up to 100 products</li>
              ");
            WriteLiteral(@"              <li class=""pricing-list-item"">100 Users Panels</li>
                        </ul>
                        <a href=""pricing.html"" class=""btn-theme btn-theme-sm btn-default-bg text-uppercase"">Choose</a>
                    </div>
                    <!-- End Pricing -->
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""wow fadeInRight"" data-wow-duration="".3"" data-wow-delay="".1s"">
                    <!-- Pricing -->
                    <div class=""pricing"">
                        <div class=""margin-b-30"">
                            <i class=""pricing-icon icon-shield""></i>
                            <h3>Advanced <span> - $</span> 249</h3>
                            <p>Lorem ipsum dolor amet consectetur ut consequat siad esqudiat dolor</p>
                        </div>
                        <ul class=""list-unstyled pricing-list margin-b-50"">
                            <li class=""pricing-list-item"">Extended Features</li>
                 ");
            WriteLiteral(@"           <li class=""pricing-list-item"">Unlimited products</li>
                            <li class=""pricing-list-item"">Unlimited Users Panels</li>
                        </ul>
                        <a href=""pricing.html"" class=""btn-theme btn-theme-sm btn-default-bg text-uppercase"">Choose</a>
                    </div>
                    <!-- End Pricing -->
                </div>
            </div>
        </div>
        <!--// end row -->
    </div>
</div>
<!-- End Pricing -->");
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
