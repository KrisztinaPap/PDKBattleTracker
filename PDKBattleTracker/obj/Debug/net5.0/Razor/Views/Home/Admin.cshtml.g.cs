#pragma checksum "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb90e364500f89eaab0a69195805c3de8ddd4bd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Admin), @"mvc.1.0.view", @"/Views/Home/Admin.cshtml")]
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
#line 1 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\_ViewImports.cshtml"
using PDKBattleTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\_ViewImports.cshtml"
using PDKBattleTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb90e364500f89eaab0a69195805c3de8ddd4bd2", @"/Views/Home/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336b954fbe35ce80f8b16bc71a8e97569d3b288a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
  
    ViewData["Admin"] = "Admin Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Admin Areas</h2>\r\n<p>");
#nullable restore
#line 6 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("Games", "Index", "Game"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 7 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("Game Sizes", "Index", "GameSize"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 8 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("Game Types", "Index", "GameType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 9 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("Game Systems", "Index", "GameSystem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 10 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("Missions", "Index", "Mission"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("Players", "Index", "Player"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 12 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("Factions", "Index", "Faction"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 13 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Home\Admin.cshtml"
Write(Html.ActionLink("SubFactions", "Index", "SubFaction"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
