#pragma checksum "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78008076c40c3d7f5c87353bd87d7531433c180c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TagHelper), @"mvc.1.0.view", @"/Views/Home/TagHelper.cshtml")]
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
#line 1 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\_ViewImports.cshtml"
using NewCore3xMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\_ViewImports.cshtml"
using NewCore3xMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78008076c40c3d7f5c87353bd87d7531433c180c", @"/Views/Home/TagHelper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8747b246c1f423209418191b43543c9079de7af4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TagHelper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
  
    ViewData["Title"] = "TagHelper";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>TagHelper</h1>\r\n\r\n\r\n<p class=\"card card-body bg-secondary\">\r\n    Attribute that starts with asp- is part of tag helper methods. Its available with almost all html tags.\r\n</p>\r\n");
#nullable restore
#line 12 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
Write("The multiplication is :" + new NewCore3xMVC.Utility.Utility().Multiply(2,3,5,9,8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 14 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
Write("The sum is " + NewCore3xMVC.Utility.Utility.Sum(2, 3, 4, 5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 16 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
   PrintTable(10); 

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\nThe sum of 2, 4 is <strong>");
#nullable restore
#line 18 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
                      Write(Sum(2, 4));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.\r\n");
#nullable restore
#line 19 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
  
    void PrintTable(int number)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 23 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
             for (var i = 1; i < 11; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 25 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
                Write(i*number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 28 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "\\192.168.50.220\Freshers2020-Trainees\NewCore3xMVC\NewCore3xMVC\Views\Home\TagHelper.cshtml"
 
    public int Sum(int a, int b)
    {
        return a + b;
    }

#line default
#line hidden
#nullable disable
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
