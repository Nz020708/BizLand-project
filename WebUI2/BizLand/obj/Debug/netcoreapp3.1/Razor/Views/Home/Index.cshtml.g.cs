#pragma checksum "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f00ddc0cab6876f50f2490d47238c6426a13116f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\_ViewImports.cshtml"
using BizLand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\_ViewImports.cshtml"
using BizLand.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml"
using BizLand.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f00ddc0cab6876f50f2490d47238c6426a13116f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9c6b0c29dfce671eebf89cab4f3d8f471d9533b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Walter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""welcome"">

        <div class=""container"">
            <div class=""col-12 "">
                <div class=""summary"">
                    <h2>
                        Welcome to <span class=""blue"">BizLand</span>
                    </h2>
                    <p>We are team of talented designers making websites with Bootstrap</p>
                    <div>
                        <button>GET STARTED</button>
                        <a href=""#"">
                            <i class=""fa-solid fa-circle-play""></i> <span>Watch Video</span>
                        </a>
                    </div>
                </div>
            </div>

        </div>

    </section>
    <section id=""features"">
        <div class=""container"">
            <div class=""row myrow"">
                <div class=""col-lg-3 col-md-6 part"">
                    <div class=""card"">
                        <div class=""icon"">
                            <i class=""fa-solid fa-basketball""></i>
     ");
            WriteLiteral(@"                   </div>
                        <div class=""title"">
                            <a href=""#"">Lorem Ipsum</a>
                        </div>
                        <div class=""about"">

                            <p>
                                Lorem Ipsum
                                Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 part"">
                    <div class=""card"">
                        <div class=""icon"">
                            <i class=""fa-solid fa-file-lines""></i>
                        </div>
                        <div class=""title"">

                            <a href=""#"">Sed ut perspiciatis</a>
                        </div>
                        <div class=""about"">

                            <p>
                                Sed ut perspiciat");
            WriteLiteral(@"is
                                Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 part"">
                    <div class=""card"">
                        <div class=""icon"">
                            <i class=""fa-solid fa-location-arrow""></i>
                        </div>
                        <div class=""title"">
                            <a href=""#"">Magni Dolores</a>
                        </div>
                        <div class=""about"">

                            <p>
                                Magni Dolores
                                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 part"">
        ");
            WriteLiteral(@"            <div class=""card"">
                        <div class=""icon"">
                            <i class=""fa-solid fa-earth-americas""></i>
                        </div>
                        <div class=""title"">
                            <a href=""#"">Nemo Enim</a>
                        </div>
                        <div class=""about"">

                            <p>
                                Nemo Enim
                                At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""about-us""></section>
    <section id=""our-team"">
        <div class=""container "">
            <h2>Our Hardworking <span class=""blue"">Team</span></h2>
            <p class=""about"">Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem");
            WriteLiteral(".</p>\r\n            <div class=\"row\">\r\n                <div class=\"card-deck cards\">\r\n");
#nullable restore
#line 111 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml"
                     foreach (var employee in Model.Team)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-6\">\r\n                            <div class=\"card\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f00ddc0cab6876f50f2490d47238c6426a13116f8914", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4518, "~/assets/images/", 4518, 16, true);
#nullable restore
#line 115 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4534, employee.Image, 4534, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title \">");
#nullable restore
#line 117 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml"
                                                       Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 118 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml"
                                                    Write(employee.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 122 "C:\Users\99470\source\repos\WebUI2\BizLand\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591