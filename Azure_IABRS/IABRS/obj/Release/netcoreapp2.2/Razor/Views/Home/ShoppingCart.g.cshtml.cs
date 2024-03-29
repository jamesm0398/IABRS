#pragma checksum "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d740836bab0a0c88243f5fc289b45f132a23d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShoppingCart), @"mvc.1.0.view", @"/Views/Home/ShoppingCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShoppingCart.cshtml", typeof(AspNetCore.Views_Home_ShoppingCart))]
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
#line 1 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
using IABRS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d740836bab0a0c88243f5fc289b45f132a23d9", @"/Views/Home/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abaf8e8892d4945b9a1b91eafa3bea422e1fe36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(21, 138, true);
            WriteLiteral("\r\n<!--File: ShoppingCart.cshtml\r\n    Purpose: This is the user\'s shopping cart, showing information about any books in their cart-->\r\n\r\n\r\n");
            EndContext();
#line 7 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
  
    ViewData["Title"] = "ShoppingCart";

#line default
#line hidden
            BeginContext(207, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
  
    var Books = (List<BookUsers>)ViewData["Books"];


#line default
#line hidden
            BeginContext(273, 245, true);
            WriteLiteral("\r\n<h1>ShoppingCart</h1>\r\n\r\n<div class=\"text-center\">\r\n\r\n</div>\r\n<!--<div class=\"container\">\r\n<div class=\"navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse\">-->\r\n<ul class=\"navbar-nav flex-grow-1\">\r\n    <li class=\"nav-item\">\r\n        ");
            EndContext();
            BeginContext(518, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18d740836bab0a0c88243f5fc289b45f132a23d96764", async() => {
                BeginContext(601, 10, true);
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
            BeginContext(615, 48, true);
            WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        ");
            EndContext();
            BeginContext(663, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18d740836bab0a0c88243f5fc289b45f132a23d98681", async() => {
                BeginContext(752, 12, true);
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
            BeginContext(768, 48, true);
            WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        ");
            EndContext();
            BeginContext(816, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18d740836bab0a0c88243f5fc289b45f132a23d910599", async() => {
                BeginContext(903, 8, true);
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
            BeginContext(915, 226, true);
            WriteLiteral("\r\n    </li>\r\n\r\n</ul>\r\n\r\n<!--Table showing list of books that the user has and can sell-->\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Author</th>\r\n        <th>ID</th>\r\n        <th>Price</th>\r\n    </tr>\r\n");
            EndContext();
#line 45 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
     foreach (var item in Books)
    {

#line default
#line hidden
            BeginContext(1182, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1213, 15, false);
#line 48 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
           Write(item.Book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1252, 16, false);
#line 49 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
           Write(item.Book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1292, 7, false);
#line 50 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1323, 15, false);
#line 51 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
           Write(item.Book.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 53 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\ShoppingCart.cshtml"
    }

#line default
#line hidden
            BeginContext(1367, 12, true);
            WriteLiteral("\r\n\r\n</table>");
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
