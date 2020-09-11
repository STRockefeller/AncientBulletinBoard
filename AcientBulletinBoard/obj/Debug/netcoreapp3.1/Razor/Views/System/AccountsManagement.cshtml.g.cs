#pragma checksum "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\System\AccountsManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3971086efe368d0e9e075261d866bc105c436774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_System_AccountsManagement), @"mvc.1.0.view", @"/Views/System/AccountsManagement.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\_ViewImports.cshtml"
using AcientBulletinBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\_ViewImports.cshtml"
using AcientBulletinBoard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3971086efe368d0e9e075261d866bc105c436774", @"/Views/System/AccountsManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72050895dee728b327099fdb239f1c9c645a5ceb", @"/Views/_ViewImports.cshtml")]
    public class Views_System_AccountsManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SystemAccountsManagementModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<center>\r\n    <div class=\"userList\">\r\n        <div class=\"card\">\r\n            <img class=\"card-img-top\" src=\"holder.js/100x180/\"");
            BeginWriteAttribute("alt", " alt=\"", 296, "\"", 302, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""card-body"">
                <h4 class=""card-title"">User List</h4>
                <div class=""container"" id=""divAccountList"">
                    <div class=""row"">
                        <div class=""col-sm-3"">
                            <b style=""color:crimson"">Account</b>
                        </div>
                        <div class=""col-sm-3"">
                            <b style=""color:crimson"">Email Address</b>
                        </div>
                        <div class=""col-sm-3"">
                            <b style=""color:crimson"">Name</b>
                        </div>
                        <div class=""col-sm-3"">
                            <b style=""color:crimson"">Camp</b>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""management"">
        <div class=""card"">
            <img class=""card-img-top"" src=""holder.js/100x180/""");
            BeginWriteAttribute("alt", " alt=\"", 1302, "\"", 1308, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <div class=\"form-group\">\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 1417, "\"", 1423, 0);
            EndWriteAttribute();
            WriteLiteral(">Search by account</label>\r\n                    <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 1511, "\"", 1518, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"InpSearchByAccount\" aria-describedby=\"helpId\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1569, "\"", 1583, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 1679, "\"", 1685, 0);
            EndWriteAttribute();
            WriteLiteral(">Search by email address</label>\r\n                    <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 1779, "\"", 1786, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"InpSearchByEmail\" aria-describedby=\"helpId\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1835, "\"", 1849, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 1945, "\"", 1951, 0);
            EndWriteAttribute();
            WriteLiteral(">Search by camp</label>\r\n                    <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 2036, "\"", 2043, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"InpSearchByCamp\" aria-describedby=\"helpId\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2091, "\"", 2105, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <button type=\"button\" class=\"btn btn-primary\" id=\"btnSearch\">Search</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</center>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3971086efe368d0e9e075261d866bc105c4367747425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var connection = new signalR.HubConnectionBuilder().withUrl(""/SystemAccountsManagementHub"").build();
        connection.on(""GenerateAccountsList"", function (listString) {
            $("".rowGenerated"").remove();
            var row = document.createElement(""div"");
            row.className = ""row rowGenerated"";
            if (listString === null)
                return;
            for (i = 0; i < listString.length; i++) {
                var Account = document.createTextNode(listString[i][0]);
                var Email = document.createTextNode(listString[i][1]);
                var Name = document.createTextNode(listString[i][2]);
                var Camp = document.createTextNode(listString[i][3]);
                var colAccount = document.createElement(""div"");
                colAccount.className = ""col-sm-3"";
                colAccount.appendChild(Account);
                var colEmail = document.createElement(""div"");
                colEmail.className = ""col-sm-3");
                WriteLiteral(@""";
                colEmail.appendChild(Email);
                var colName = document.createElement(""div"");
                colName.className = ""col-sm-3"";
                colName.appendChild(Name);
                var colCamp = document.createElement(""div"");
                colCamp.className = ""col-sm-3"";
                colCamp.appendChild(Camp);
                row.appendChild(colAccount);
                row.appendChild(colEmail);
                row.appendChild(colName);
                row.appendChild(colCamp);
            }
            document.getElementById(""divAccountList"").appendChild(row);
        });

        connection.start().catch(function (err) {
            return console.error(err.toString());
        });

        document.getElementById(""btnSearch"").addEventListener(""click"", function (event) {
            var searchByAccount = document.getElementById(""InpSearchByAccount"").value;
            var searchByEmail = document.getElementById(""InpSearchByEmail"").value;
     ");
                WriteLiteral(@"       var searchByCamp = document.getElementById(""InpSearchByCamp"").value;
            connection.invoke(""UpdateAccountsList"", searchByAccount, searchByEmail, searchByCamp).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemAccountsManagementModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
