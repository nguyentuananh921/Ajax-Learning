#pragma checksum "E:\Coding Learning\Working\Ajax-Learning\jQuery Ajax Employee CRUD\WebMVC\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36444c29d06e449a0435974912ae1abeddad4b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "E:\Coding Learning\Working\Ajax-Learning\jQuery Ajax Employee CRUD\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Coding Learning\Working\Ajax-Learning\jQuery Ajax Employee CRUD\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36444c29d06e449a0435974912ae1abeddad4b53", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Coding Learning\Working\Ajax-Learning\jQuery Ajax Employee CRUD\WebMVC\Views\Employee\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
    <li class=""nav-item"" role=""presentation"">
        <button class=""nav-link active"" id=""home-tab"" data-bs-toggle=""tab"" data-bs-target=""#home"" type=""button"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Home</button>
    </li>
    <li class=""nav-item"" role=""presentation"">
        <button class=""nav-link"" id=""profile-tab"" data-bs-toggle=""tab"" data-bs-target=""#profile"" type=""button"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Profile</button>
    </li>
    <li class=""nav-item"" role=""presentation"">
        <button class=""nav-link"" id=""contact-tab"" data-bs-toggle=""tab"" data-bs-target=""#contact"" type=""button"" role=""tab"" aria-controls=""contact"" aria-selected=""false"">Contact</button>
    </li>
</ul>
<div class=""tab-content"" id=""myTabContent"">
    <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
        Home come here
    </div>
    <div class=""tab-pane fade"" id=""profile"" role=""tabpa");
            WriteLiteral("nel\" aria-labelledby=\"profile-tab\">\r\n        Profile come here\r\n    </div>\r\n    <div class=\"tab-pane fade\" id=\"contact\" role=\"tabpanel\" aria-labelledby=\"contact-tab\">\r\n        Contact come here\r\n    </div>\r\n</div>");
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