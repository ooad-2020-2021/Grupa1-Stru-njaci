#pragma checksum "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18cf14c2448f7c88c89b76d3aec8432c3b163e7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UtisakMacka_Index___Copy), @"mvc.1.0.view", @"/Views/UtisakMacka/Index - Copy.cshtml")]
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
#line 1 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18cf14c2448f7c88c89b76d3aec8432c3b163e7b", @"/Views/UtisakMacka/Index - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfb7ca88e7d849119cde011028e102232e06fef", @"/Views/_ViewImports.cshtml")]
    public class Views_UtisakMacka_Index___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpaceCat.UtisakMacka>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18cf14c2448f7c88c89b76d3aec8432c3b163e7b4718", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<style>\r\n    ");
            WriteLiteral(@"@import url(http://fonts.googleapis.com/css?family=Calibri:400,300,700);

body {
    background-color: cornflowerblue;
    font-family: 'Calibri', sans-serif !important
}

.mt-100 {
    margin-top: 100px
}

.mb-100 {
    margin-bottom: 100px
}

.card {
    position: relative;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
    min-width: 0;
    word-wrap: break-word;
    background-color: #fff;
    background-clip: border-box;
    border: 0px solid transparent;
    border-radius: 0px
}

.card-body {
    -webkit-box-flex: 1;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    padding: 1.25rem
}

.card .card-title {
    position: relative;
    font-weight: 600;
    margin-bottom: 10px
}

.comment-widgets {
    position: relative;
    margin-bottom: 10px
}

.comment-widgets .comment-row {
    border-bottom: 1px solid");
            WriteLiteral(@" transparent;
    padding: 14px;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    margin: 10px 0
}

.p-2 {
    padding: 0.5rem !important
}

.comment-text {
    padding-left: 15px
}

.w-100 {
    width: 100% !important
}

.m-b-15 {
    margin-bottom: 15px
}

.btn-sm {
    padding: 0.25rem 0.5rem;
    font-size: 0.76563rem;
    line-height: 1.5;
    border-radius: 1px
}

.btn-cyan {
    color: #fff;
    background-color: #27a9e3;
    border-color: #27a9e3
}

.btn-cyan:hover {
    color: #fff;
    background-color: #1a93ca;
    border-color: #198bbe
}

.comment-widgets .comment-row:hover {
    background: rgba(0, 0, 0, 0.05)
}
</style>

<table class=""table"">
    <tbody>
        <div class=""row d-flex justify-content-center mt-100 mb-100"">
            <div class=""col-lg-6"">
                <div class=""card"">
                    <div class=""card-body text-center"">
                        <h4 class=""card-title"">Latest Comments</h4>
  ");
            WriteLiteral("                  </div>\r\n                    <div class=\"comment-widgets\">\r\n");
#nullable restore
#line 122 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- Comment Row -->\r\n                            <div class=\"d-flex flex-row comment-row m-t-0\">\r\n                                <div class=\"p-2\" style=\"height:10em;\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=", 2620, "", 2667, 1);
#nullable restore
#line 127 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
WriteAttributeValue("", 2625, Html.DisplayNameFor(model => model.Slika), 2625, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"user\" width=\"50\" height=\"10em\" class=\"rounded-circle\">\r\n                                </div>\r\n                                <div class=\"comment-text w-100\">\r\n                                    <h6 class=\"font-medium\">");
#nullable restore
#line 130 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.ImeMacke));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <span class=\"m-b-15 d-block\">");
#nullable restore
#line 131 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                                                            Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    <div class=""comment-footer"">  <button type=""button"" class=""btn btn-cyan btn-sm"">Edit</button> <button type=""button"" class=""btn btn-success btn-sm"">Publish</button> <button type=""button"" class=""btn btn-danger btn-sm"">Delete</button> </div>
                                </div>
                            </div> <!-- Comment Row -->
");
#nullable restore
#line 135 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div> <!-- Card -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 148 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
               Write(Html.DisplayNameFor(model => model.ImeMacke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 151 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
               Write(Html.DisplayNameFor(model => model.Slika));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 154 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
               Write(Html.DisplayNameFor(model => model.OdabranaRanije));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 157 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
               Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 160 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
               Write(Html.DisplayNameFor(model => model.Ocjena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 166 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 170 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ImeMacke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4548, "\"", 4595, 1);
#nullable restore
#line 173 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
WriteAttributeValue("", 4554, Html.DisplayFor(modelItem => item.Slika), 4554, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 176 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OdabranaRanije));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 179 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 182 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ocjena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18cf14c2448f7c88c89b76d3aec8432c3b163e7b15313", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 185 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18cf14c2448f7c88c89b76d3aec8432c3b163e7b17529", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                                                  WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18cf14c2448f7c88c89b76d3aec8432c3b163e7b19751", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 187 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
                                                 WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 190 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\UtisakMacka\Index - Copy.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpaceCat.UtisakMacka>> Html { get; private set; }
    }
}
#pragma warning restore 1591
