#pragma checksum "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e8c28abf60c7a7d3d812fb818dc93baab8ad21c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Details), @"mvc.1.0.view", @"/Views/Game/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e8c28abf60c7a7d3d812fb818dc93baab8ad21c", @"/Views/Game/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336b954fbe35ce80f8b16bc71a8e97569d3b288a", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PDKBattleTracker.Models.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Game</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GameDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.GameDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GameSystemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.GameSystemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GameTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.GameTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GameSizeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.GameSizeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MissionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.MissionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.FactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubFactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubFactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player1Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 218 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 221 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 224 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 227 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 230 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 233 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 236 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 239 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 242 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 245 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 248 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 251 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
       Write(Html.DisplayFor(model => model.Player2Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8c28abf60c7a7d3d812fb818dc93baab8ad21c30427", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 256 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Details.cshtml"
                           WriteLiteral(Model.GameId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8c28abf60c7a7d3d812fb818dc93baab8ad21c32573", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PDKBattleTracker.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
