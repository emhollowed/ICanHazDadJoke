#pragma checksum "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ac32fb590c680a7dc9bbf4a19137d93ccd98725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\_ViewImports.cshtml"
using CanIHazDadJoke;

#line default
#line hidden
#line 2 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\_ViewImports.cshtml"
using CanIHazDadJoke.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ac32fb590c680a7dc9bbf4a19137d93ccd98725", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4094378010ea352b8e7fcccdb03e488adfe3a3b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CanIHazDadJoke.Models.HomeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-sm mr-3 w-75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchInput"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Pun Me"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline md-form form-sm active-cyan-2 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 85, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <p class=\"lead text-center\" id=\"rotatingJoke\">");
            EndContext();
            BeginContext(126, 15, false);
#line 5 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                                             Write(Model.Joke.Joke);

#line default
#line hidden
            EndContext();
            BeginContext(141, 12, true);
            WriteLiteral("</p>\r\n\r\n    ");
            EndContext();
            BeginContext(153, 386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4828e10fb9164fa2a0e30a151ae09e73", async() => {
                BeginContext(271, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(281, 145, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b56c22256ee24517884e37076f0d21fd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 8 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchTerm);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(426, 106, true);
                WriteLiteral("\r\n        <button id=\"searchButton\" class=\"fas fa-search\" type=\"submit\" aria-hidden=\"true\"></button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(539, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
     if (Model.SearchResults != null)
    {

#line default
#line hidden
            BeginContext(589, 113, true);
            WriteLiteral("        <div class=\"row\" id=\"resultDataRow\">\r\n            <div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\">\r\n\r\n");
            EndContext();
#line 17 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                 if (@Model.SearchResults.TotalJokes > 30)
                {

#line default
#line hidden
            BeginContext(781, 35, true);
            WriteLiteral("                    <p>Showing: 30/");
            EndContext();
            BeginContext(817, 30, false);
#line 19 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                              Write(Model.SearchResults.TotalJokes);

#line default
#line hidden
            EndContext();
            BeginContext(847, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                }
                else if (@Model.SearchResults.TotalJokes == 0){

#line default
#line hidden
            BeginContext(937, 89, true);
            WriteLiteral("                    <p>Showing : 0/0</p>\r\n                    <p>No pun intended :(</p>\r\n");
            EndContext();
#line 24 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1086, 32, true);
            WriteLiteral("                    <p>Showing: ");
            EndContext();
            BeginContext(1119, 30, false);
#line 27 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                           Write(Model.SearchResults.TotalJokes);

#line default
#line hidden
            EndContext();
            BeginContext(1149, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(1151, 30, false);
#line 27 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                                                           Write(Model.SearchResults.TotalJokes);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 28 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1206, 590, true);
            WriteLiteral(@"
            </div>
            <div class=""col-lg-1 col-md-2 col-sm-2 col-xs-4"">
                <div id=""short"" class=""square"">S</div>
            </div>
            <div class=""col-lg-1 col-md-2 col-sm-2 col-xs-4"">
                <div id=""medium"" class=""square"">M</div>
            </div>
            <div class=""col-lg-1 col-md-2 col-sm-2 col-xs-4"">
                <div id=""long"" class=""square""><span>L</span></div>
            </div>
        </div>
        <div class=""row"" id=""searchResultsRow"">
            <ul class=""list-group list-group-flush"" id=""searchResults"">
");
            EndContext();
#line 43 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                 foreach (var joke in Model.SearchResults.Results)
                {

#line default
#line hidden
            BeginContext(1883, 60, true);
            WriteLiteral("                    <li class=\"list-group-item joke-result\">");
            EndContext();
            BeginContext(1944, 9, false);
#line 45 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                                                       Write(joke.Joke);

#line default
#line hidden
            EndContext();
            BeginContext(1953, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 46 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1979, 35, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n");
            EndContext();
#line 49 "C:\Users\emhol\GitHubProjects\CanIHazDadJoke\CanIHazDadJoke\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2021, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CanIHazDadJoke.Models.HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
