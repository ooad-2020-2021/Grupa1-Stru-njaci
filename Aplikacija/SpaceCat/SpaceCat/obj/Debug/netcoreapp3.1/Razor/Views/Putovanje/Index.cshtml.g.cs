#pragma checksum "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1df8a068e8f7df5faccf92eadf6153c26c3ffcfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Putovanje_Index), @"mvc.1.0.view", @"/Views/Putovanje/Index.cshtml")]
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
#line 1 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df8a068e8f7df5faccf92eadf6153c26c3ffcfe", @"/Views/Putovanje/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfb7ca88e7d849119cde011028e102232e06fef", @"/Views/_ViewImports.cshtml")]
    public class Views_Putovanje_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpaceCat.Putovanje>>
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
            WriteLiteral(@"<style>
    body {
        color: snow;
        background-image: url(""https://i.ibb.co/h10jKh0/novapoz.png"");
        height: 100%;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
    }
    /* general styling */
    #countd {
        box-sizing: border-box;
        margin: 0;
        padding: 0;
    }

    #countd {
        height: 100%;
        margin: 0;
    }

    #countd {
        align-items: center;
        opacity: 0.6;
        background-color: black;
        display: flex;
        font-family: -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, Oxygen-Sans, Ubuntu, Cantarell, ""Helvetica Neue"", sans-serif;
    }

    .container {
        color: snow;
        margin: 0 auto;
        text-align: center;
    }

    h1 {
        font-weight: normal;
        letter-spacing: .125rem;
        text-transform: uppercase;
    }

    #hours, #minutes, #days, #seconds, #s1, #s2, #s3, #s4 {
        display: inl");
            WriteLiteral(@"ine-block;
        font-size: 1.5em;
        list-style-type: none;
        padding: 1em;
        text-transform: uppercase;
    }

    #hours, #minutes, #days, #seconds {
        display: block;
        font-size: 4.5rem;
    }



    #hours, #minutes, #days, #seconds {
        font-size: 4rem;
        padding: 0 .5rem;
    }

    #let {
        color: snow;
    }
</style>

");
#nullable restore
#line 68 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 id=\"let\">NAREDNI LET</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df8a068e8f7df5faccf92eadf6153c26c3ffcfe6157", async() => {
                WriteLiteral("Dodaj putovanje");
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
            WriteLiteral("\r\n</p>\r\n<!--\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 83 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.VrijemePolaska));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 86 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.KrajPutovanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 92 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 96 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VrijemePolaska));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 99 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KrajPutovanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df8a068e8f7df5faccf92eadf6153c26c3ffcfe9145", async() => {
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
#line 102 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df8a068e8f7df5faccf92eadf6153c26c3ffcfe11339", async() => {
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
#line 103 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df8a068e8f7df5faccf92eadf6153c26c3ffcfe13540", async() => {
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
#line 104 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 107 "C:\Users\Belma fax\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Putovanje\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
-->

<div class=""container"" id=""countd"">
    <h1 id=""headline"">   Do narednog leta:</h1>
    <br />
    <div id=""countdown"">
        <ul>
            <li id=""s1""><span id=""days""></span>dana</li>
            <li id=""s2""><span id=""hours""></span>sati</li>
            <li id=""s3""><span id=""minutes""></span>minuta</li>
            <li id=""s4""><span id=""seconds""></span>sekundi</li>
        </ul>
    </div>

</div>

<script>
(function () {
  const second = 1000,
        minute = second * 60,
        hour = minute * 60,
        day = hour * 24;

  let birthday = ""Sep 29, 2021 00:00:00"",
      countDown = new Date(birthday).getTime(),
      x = setInterval(function() {

        let now = new Date().getTime(),
            distance = countDown - now;

        document.getElementById(""days"").innerText = Math.floor(distance / (day)),
          document.getElementById(""hours"").innerText = Math.floor((distance % (day)) / (hour)),
          document.getElementById(""minut");
            WriteLiteral(@"es"").innerText = Math.floor((distance % (hour)) / (minute)),
          document.getElementById(""seconds"").innerText = Math.floor((distance % (minute)) / second);

        //do something later when date is reached
        if (distance < 0) {
          let headline = document.getElementById(""headline""),
              countdown = document.getElementById(""countdown""),
              content = document.getElementById(""content"");

          headline.innerText = ""Naredni let"";
          countdown.style.display = ""none"";
          content.style.display = ""block"";

          clearInterval(x);
        }
        //seconds
      }, 0)
  }());
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpaceCat.Putovanje>> Html { get; private set; }
    }
}
#pragma warning restore 1591
