#pragma checksum "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f818f8aeb77550c6e1e82253634f7fe0262d4674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\_ViewImports.cshtml"
using Dojo_Survey_Valid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\_ViewImports.cshtml"
using Dojo_Survey_Valid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f818f8aeb77550c6e1e82253634f7fe0262d4674", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442fcff2aa87d9f4e526e03389033c388d1d8066", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Landing Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1 style = \"text-decoration: underline\">Submitted Info</h1>\r\n<p>Name: ");
#nullable restore
#line 8 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\Home\Result.cshtml"
    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Dojo Location: ");
#nullable restore
#line 9 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\Home\Result.cshtml"
             Write(Model.Dojo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Favorite Language: ");
#nullable restore
#line 10 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\Home\Result.cshtml"
                 Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Comment: ");
#nullable restore
#line 11 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey_Valid\Views\Home\Result.cshtml"
       Write(Model.Comment);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591