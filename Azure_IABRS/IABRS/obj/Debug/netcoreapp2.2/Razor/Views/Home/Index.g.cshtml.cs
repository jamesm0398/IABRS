#pragma checksum "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a8cf2a0340d9e83c44c68768410e04c341e35cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml"
using IABRS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8cf2a0340d9e83c44c68768410e04c341e35cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abaf8e8892d4945b9a1b91eafa3bea422e1fe36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 120, true);
            WriteLiteral("\r\n<!--File: Index.cshtml\r\n    Purpose: This is the entry point of the website, showing a simple welcome message-->\r\n\r\n\r\n");
            EndContext();
#line 7 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(186, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml"
  
    var InstitutionData = (Institution)ViewData["instInfo"];


#line default
#line hidden
            BeginContext(261, 29, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 18 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml"
       if (InstitutionData == null)
        {

#line default
#line hidden
            BeginContext(338, 94, true);
            WriteLiteral("            <h1 class=\"display-4\">Welcome to IABRS please register or login to contiune</h1>\r\n");
            EndContext();
#line 21 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(468, 45, true);
            WriteLiteral("            <h1 class=\"display-4\">Welcome to ");
            EndContext();
            BeginContext(514, 20, false);
#line 24 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml"
                                        Write(InstitutionData.Name);

#line default
#line hidden
            EndContext();
            BeginContext(534, 20, true);
            WriteLiteral("\'s book store</h1>\r\n");
            EndContext();
#line 25 "D:\conestoga\SoftwareEngTech\Repo\school_code\Semester5\Network Application Design\Assignment5_Prof_of_Con\working_Copy\IABRS\Azure_IABRS\IABRS\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(572, 124, true);
            WriteLiteral("\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
