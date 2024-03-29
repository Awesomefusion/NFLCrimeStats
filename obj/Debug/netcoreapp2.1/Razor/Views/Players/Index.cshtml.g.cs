#pragma checksum "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "730aaa16359957b33adfaedddd59575265f95adb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_Index), @"mvc.1.0.view", @"/Views/Players/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Players/Index.cshtml", typeof(AspNetCore.Views_Players_Index))]
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
#line 1 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\_ViewImports.cshtml"
using NFLCrimeStats;

#line default
#line hidden
#line 2 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\_ViewImports.cshtml"
using NFLCrimeStats.Models;

#line default
#line hidden
#line 1 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml"
using NFLCrimeStats.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730aaa16359957b33adfaedddd59575265f95adb", @"/Views/Players/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1dc85f97cfec6d324e71d2ec94affd4a2b98b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NFLCrimeStats.Models.PlayerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml"
  
    ViewData["Title"] = "Top Players";

#line default
#line hidden
            BeginContext(130, 26, true);
            WriteLiteral("\r\n<h2>Top Players</h2>\r\n\r\n");
            EndContext();
            BeginContext(162, 273, true);
            WriteLiteral(@"    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Team</th>
                <th scope=""col"">Total Arrests</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(492, 63, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <p>");
            EndContext();
            BeginContext(556, 160, false);
#line 25 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml"
                  Write(Html.ActionLink(linkText: item.Name, actionName: "PlayerCrimesAll", controllerName: "Crimes", routeValues: new { playerName = item.Name }, htmlAttributes: null));

#line default
#line hidden
            EndContext();
            BeginContext(716, 76, true);
            WriteLiteral("</p>\r\n                </td>\r\n\r\n                <td>\r\n                    <p>");
            EndContext();
            BeginContext(793, 184, false);
#line 29 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml"
                  Write(Html.ActionLink(linkText: item.Team_Name, actionName: "TeamTopPlayers", controllerName: "Teams", routeValues: new { team = item.Team, teamName = item.Team_Name }, htmlAttributes: null));

#line default
#line hidden
            EndContext();
            BeginContext(977, 74, true);
            WriteLiteral("</p>\r\n                </td>\r\n                <td>\r\n                    <p>");
            EndContext();
            BeginContext(1052, 43, false);
#line 32 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml"
                  Write(Html.DisplayFor(model => item.Arrest_Count));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 48, true);
            WriteLiteral("</p>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Alexm\Documents\CodeTests\WEB\NFLCrimeStats\Views\Players\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1158, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NFLCrimeStats.Models.PlayerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
