#pragma checksum "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c495f840a5fdd1d18431fbf4b36517f921c0faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CampBulletinBoard_Index), @"mvc.1.0.view", @"/Views/CampBulletinBoard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c495f840a5fdd1d18431fbf4b36517f921c0faf", @"/Views/CampBulletinBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72050895dee728b327099fdb239f1c9c645a5ceb", @"/Views/_ViewImports.cshtml")]
    public class Views_CampBulletinBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampBulletinBoardModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inpName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-describedby", new global::Microsoft.AspNetCore.Html.HtmlString("helpId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inpComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CampBulletinBoard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<hr size=1>\r\n<center>\r\n    <h3><b>Camp Bulletin Board : ");
#nullable restore
#line 10 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
                            Write(Model.user.camp.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n    <div class=\"Board\">\r\n        <ul class=\"list-group\">\r\n");
#nullable restore
#line 13 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
             foreach (var comment in @Model.comments)
            {
                string color;
                switch (comment.camp)
                {
                    case "Shu":
                        color = "green";
                        break;
                    case "Wu":
                        color = "red";
                        break;
                    case "Wei":
                        color = "blue";
                        break;
                    case "Neutral":
                        color = "gray";
                        break;
                    case "God":
                        color = "gold";
                        break;
                    case "Foreign":
                        color = "silver";
                        break;
                    default:
                        color = "black";
                        break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list - group - item\"");
            BeginWriteAttribute("style", " style=\"", 1289, "\"", 1309, 2);
            WriteAttributeValue("", 1297, "color:", 1297, 6, true);
#nullable restore
#line 40 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
WriteAttributeValue("", 1303, color, 1303, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
                                                                Write(comment.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 40 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
                                                                                Write(comment.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 40 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
                                                                                                  Write(comment.dateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 41 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"card text-left\">\r\n        <img class=\"card-img-top\" src=\"holder.js/100px180/\"");
            BeginWriteAttribute("alt", " alt=\"", 1504, "\"", 1510, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Public Bulletin Board</h4>\r\n            <div class=\"form-group\">\r\n                <label");
            BeginWriteAttribute("for", " for=\"", 1670, "\"", 1676, 0);
            EndWriteAttribute();
            WriteLiteral(">Name</label>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c495f840a5fdd1d18431fbf4b36517f921c0faf9940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 50 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.user.name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <p class=\"card-text\">\r\n                <div class=\"form-group\">\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 1979, "\"", 1985, 0);
            EndWriteAttribute();
            WriteLiteral(">Comment</label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c495f840a5fdd1d18431fbf4b36517f921c0faf12448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 56 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.comment);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <button type=\"button\" class=\"btn btn-primary\" id=\"btnSubmit\">Submit</button>\r\n                <button type=\"button\" class=\"btn btn-primary\" onclick=\"history.back()\">Back</button>\r\n");
#nullable restore
#line 61 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
                 if (@Model.user.role == AcientBulletinBoard.Services.enumRole.admin)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-primary\" id=\"btnClearBoard\">Clear the Board</button>\r\n");
#nullable restore
#line 64 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</center>\r\n<input type=\"text\"\r\n       class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 2737, "\"", 2744, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"InpCamp\" aria-describedby=\"helpId\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2784, "\"", 2798, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"undefined\">\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function(){\r\n            $(\"#InpCamp\").val(\'");
#nullable restore
#line 75 "C:\Users\admin\source\repos\AcientBulletinBoard\AcientBulletinBoard\Views\CampBulletinBoard\Index.cshtml"
                          Write(Model.user.camp.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            $(\"#InpCamp\").hide();\r\n        })\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c495f840a5fdd1d18431fbf4b36517f921c0faf16594", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampBulletinBoardModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
