#pragma checksum "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ef980dcfd98781964509687ed0f607ad241553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BuyBooks), @"mvc.1.0.view", @"/Views/Home/BuyBooks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BuyBooks.cshtml", typeof(AspNetCore.Views_Home_BuyBooks))]
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
#line 1 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\_ViewImports.cshtml"
using IABRS;

#line default
#line hidden
#line 3 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
using IABRS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ef980dcfd98781964509687ed0f607ad241553", @"/Views/Home/BuyBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abaf8e8892d4945b9a1b91eafa3bea422e1fe36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BuyBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YourProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SellBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(21, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
  
    ViewData["Title"] = "BuyBooks";

#line default
#line hidden
            BeginContext(69, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
  
    var Books = (List<Book>)ViewData["Books"];


#line default
#line hidden
            BeginContext(130, 243, true);
            WriteLiteral("\r\n\r\n<h1>BuyBooks</h1>\r\n\r\n<div class=\"text-center\">\r\n\r\n</div>\r\n<!--<div class=\"container\">\r\n<div class=\"navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse\">-->\r\n<ul class=\"navbar-nav flex-grow-1\">\r\n    <li class=\"nav-item\">\r\n        ");
            EndContext();
            BeginContext(373, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ef980dcfd98781964509687ed0f607ad2415536570", async() => {
                BeginContext(456, 10, true);
                WriteLiteral("Your Books");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(470, 48, true);
            WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        ");
            EndContext();
            BeginContext(518, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ef980dcfd98781964509687ed0f607ad2415538487", async() => {
                BeginContext(607, 12, true);
                WriteLiteral("Your Courses");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(623, 48, true);
            WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        ");
            EndContext();
            BeginContext(671, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ef980dcfd98781964509687ed0f607ad24155310405", async() => {
                BeginContext(758, 8, true);
                WriteLiteral("Settings");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(770, 230, true);
            WriteLiteral("\r\n    </li>\r\n\r\n</ul>\r\n\r\n<!--Table showing list of books that the user has and can sell-->\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Author</th>\r\n        <th>ISBN</th>\r\n        <th>Picture</th>\r\n    </tr>\r\n");
            EndContext();
#line 43 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
     foreach (var item in Books)
    {

#line default
#line hidden
            BeginContext(1041, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1072, 10, false);
#line 46 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1082, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1106, 11, false);
#line 47 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
           Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1117, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1141, 11, false);
#line 48 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
           Write(item.BookId);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 92, true);
            WriteLiteral("</td>\r\n            <td><input type=\"button\" value=\"Put Up For Sale\" /></td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\BuyBooks.cshtml"
    }

#line default
#line hidden
            BeginContext(1251, 18, true);
            WriteLiteral("\r\n\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
