#pragma checksum "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b43c0e55f7aefc7f2d4df8b2560ff97ebd323628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Details), @"mvc.1.0.view", @"/Views/Branch/Details.cshtml")]
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
#line 1 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\_ViewImports.cshtml"
using Bumbo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\_ViewImports.cshtml"
using Bumbo.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43c0e55f7aefc7f2d4df8b2560ff97ebd323628", @"/Views/Branch/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e2f0ca9b4a70efd240b47401d999e81bbe6eca", @"/Views/_ViewImports.cshtml")]
    public class Views_Branch_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BranchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
  
    ViewData["Title"] = "Branch details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"w-75\">\r\n    <div class=\"mb-3\">\r\n        <h1 class=\"text-white\">");
#nullable restore
#line 8 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                          Write(Model.Branch.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    </div>
    <div class=""row"">
        <div class=""col"">
            <div class=""shadow border p-3 bg-white rounded"">
                <h2 class=""mb-3"">Branchgegevens</h2>
                <dl class=""row"">
                    <dt class=""col-sm-4"">
                        ");
#nullable restore
#line 16 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 19 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 22 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.ShelvesLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 25 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.ShelvesLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("m\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 28 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 31 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 34 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 37 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 40 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 43 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 46 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 49 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 52 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 55 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 58 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 61 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 64 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 67 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 70 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Branch.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 73 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Branch.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43c0e55f7aefc7f2d4df8b2560ff97ebd32362812203", async() => {
                WriteLiteral("Terug");
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
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""shadow border p-3 bg-white rounded"">
                <h2 class=""mb-3"">Openingstijden</h2>
                <dl class=""row"">
                    <dt class=""col-sm-3"">
                        Maandag
                    </dt>
                    <dd class=""col-sm-8"">
                        ");
#nullable restore
#line 89 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Model.Monday.OpenTime.ToString().Substring(0, @Model.Monday.OpenTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 89 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                                                                                                                  Write(Model.Monday.CloseTime.ToString().Substring(0, @Model.Monday.CloseTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        Dinsdag\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 95 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Model.Tuesday.OpenTime.ToString().Substring(0, @Model.Tuesday.OpenTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 95 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                                                                                                                    Write(Model.Tuesday.CloseTime.ToString().Substring(0, @Model.Tuesday.CloseTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        Woensdag\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 101 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Model.Wednesday.OpenTime.ToString().Substring(0, @Model.Wednesday.OpenTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 101 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                                                                                                                        Write(Model.Wednesday.CloseTime.ToString().Substring(0, @Model.Wednesday.CloseTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        Donderdag\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 107 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Model.Thursday.OpenTime.ToString().Substring(0, @Model.Thursday.OpenTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 107 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                                                                                                                      Write(Model.Thursday.CloseTime.ToString().Substring(0, @Model.Thursday.CloseTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        Vrijdag\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 113 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Model.Friday.OpenTime.ToString().Substring(0, @Model.Friday.OpenTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 113 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                                                                                                                  Write(Model.Friday.CloseTime.ToString().Substring(0, @Model.Friday.CloseTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        Zaterdag\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 119 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Model.Saturday.OpenTime.ToString().Substring(0, @Model.Saturday.OpenTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 119 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                                                                                                                      Write(Model.Saturday.CloseTime.ToString().Substring(0, @Model.Saturday.CloseTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        Zondag\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 125 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                   Write(Model.Sunday.OpenTime.ToString().Substring(0, @Model.Sunday.OpenTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 125 "C:\Projects\C#\AVANS 2021\Bumbo\soprj6-groep-k\Bumbo.Web\Views\Branch\Details.cshtml"
                                                                                                                  Write(Model.Sunday.CloseTime.ToString().Substring(0, @Model.Sunday.CloseTime.ToString().Length - 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BranchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
