#pragma checksum "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c176d73b1ca791e668f8e86d105e8b4274fbbcf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c176d73b1ca791e668f8e86d105e8b4274fbbcf", @"/Views/Game/Delete.cshtml")]
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
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <div>\r\n        <p>");
#nullable restore
#line 12 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
      Write(Html.DisplayNameFor(model => model.GameDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 12 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                                                      Write(Html.DisplayFor(model => model.GameDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
    <div class=""d-lg-flex"">
        <div class=""table-responsive"">
            <table class=""table table-striped table-bordered table-hover"">
                <thead>
                    <tr>
                        <th colspan=""2"">
                            Player 1
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            ");
#nullable restore
#line 27 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 30 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 35 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player1Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 38 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player1Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player1SubFaction))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Player1SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player1Custom1))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Player1Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 62 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player1Custom2))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 67 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Player1Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 73 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 76 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 79 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player1PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player1PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 95 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player1PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 100 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player1PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 103 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player1PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 106 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player1Secondary1text) && Model.Player1Secondary1text.ToString() != "Secondary #1 (optional)")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 110 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 113 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 116 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player1Secondary2) && Model.Player1Secondary2.ToString() != "Secondary #2 (optional)")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 121 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 124 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 127 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player1Secondary3) && Model.Player1Secondary3.ToString() != "Secondary #3 (optional)")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 132 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 135 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player1Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 138 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>

            </table>
        </div>
        <div class=""table-responsive"">
            <table class=""table table-striped table-bordered table-hover"">
                <thead>
                    <tr>
                        <th colspan=""2"">
                            Player 2
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            ");
#nullable restore
#line 155 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 158 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 163 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player2Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 166 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player2Faction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 169 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player2SubFaction))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 173 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Player2SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 176 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2SubFaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 179 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player2Custom1))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 184 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Player2Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 187 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Custom1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 190 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player2Custom2))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 195 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Player2Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 198 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Custom2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 201 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 204 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 207 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player2PrimaryRound2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 212 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 215 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player2PrimaryRound3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 220 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 223 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player2PrimaryRound4Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 228 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Player2PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 231 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Player2PrimaryRound5Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 234 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player2Secondary1text) && Model.Player2Secondary1text.ToString() != "Secondary #1 (optional)")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 238 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Secondary1text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 241 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Secondary1Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 244 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 245 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player2Secondary2) && Model.Player2Secondary2.ToString() != "Secondary #2 (optional)")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 249 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Secondary2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 252 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Secondary2Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 255 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 256 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                     if (!String.IsNullOrEmpty(Model.Player2Secondary3) && Model.Player2Secondary3.ToString() != "Secondary #3 (optional)")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 260 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Secondary3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 263 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Player2Secondary3Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 266 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c176d73b1ca791e668f8e86d105e8b4274fbbcf32108", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c176d73b1ca791e668f8e86d105e8b4274fbbcf32375", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 274 "C:\Code\ASPDOTNET\PDKBattleTracker\PDKBattleTracker\Views\Game\Delete.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c176d73b1ca791e668f8e86d105e8b4274fbbcf34164", async() => {
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
