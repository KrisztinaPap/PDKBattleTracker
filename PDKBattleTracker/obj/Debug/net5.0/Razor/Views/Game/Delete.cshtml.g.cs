#pragma checksum "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "932c9a616c80a77191c5876a17601b11ebe3eb47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Delete), @"mvc.1.0.view", @"/Views/Game/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932c9a616c80a77191c5876a17601b11ebe3eb47", @"/Views/Game/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336b954fbe35ce80f8b16bc71a8e97569d3b288a", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PDKBattleTracker.Models.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Game</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GameDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GameDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GameSystemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GameSystemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GameTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GameTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GameSizeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GameSizeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MissionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MissionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PlayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PlayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubFactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubFactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player1Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player1Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 207 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 210 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 213 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 216 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 219 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 222 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 225 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 228 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 231 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 234 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 237 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 240 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 243 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 246 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 249 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Player2Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 252 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Player2Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "932c9a616c80a77191c5876a17601b11ebe3eb4731087", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "932c9a616c80a77191c5876a17601b11ebe3eb4731354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 257 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GameId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "932c9a616c80a77191c5876a17601b11ebe3eb4733143", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
