#pragma checksum "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\Register\DisplayRegistrant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f300aff93221b3e2300dd3c5232d3f4ef7302a14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_DisplayRegistrant), @"mvc.1.0.view", @"/Views/Register/DisplayRegistrant.cshtml")]
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
#line 1 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\_ViewImports.cshtml"
using Lab18;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\_ViewImports.cshtml"
using Lab18.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f300aff93221b3e2300dd3c5232d3f4ef7302a14", @"/Views/Register/DisplayRegistrant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70e059428937f0d76af096067ed9f12b3004ee9", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_DisplayRegistrant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18.Models.Registrant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\Register\DisplayRegistrant.cshtml"
  
    ViewData["Title"] = "DisplayRegistrant";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Display Registrant</h1>\r\n\r\n<p>Hi, ");
#nullable restore
#line 10 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\Register\DisplayRegistrant.cshtml"
  Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("! You have just registered! Your Password is ");
#nullable restore
#line 10 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\Register\DisplayRegistrant.cshtml"
                                                               Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral(", your phone is ");
#nullable restore
#line 10 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\Register\DisplayRegistrant.cshtml"
                                                                                              Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and your email address is ");
#nullable restore
#line 10 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\Register\DisplayRegistrant.cshtml"
                                                                                                                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("!!</p><br />\r\n<p>You were born on ");
#nullable restore
#line 11 "C:\Users\Tristan\Documents\BootCamp\Lab18\Lab18\Views\Register\DisplayRegistrant.cshtml"
               Write(Model.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18.Models.Registrant> Html { get; private set; }
    }
}
#pragma warning restore 1591
