#pragma checksum "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b85b18c3008853814234421daa7d738542950cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\_ViewImports.cshtml"
using FCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\_ViewImports.cshtml"
using FCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b85b18c3008853814234421daa7d738542950cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c8aceab6a8888f62d143e8ab3a0b7b6253c5cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"featured-services\" class=\"featured-services\">\r\n    <div class=\"container aos-init aos-animate\" data-aos=\"fade-up\">\r\n\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6 col-lg-3 d-flex align-items-stretch my-5 mb-lg-0"">
                    <div class=""icon-box aos-init aos-animate"" style=""width:100%"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <center>
                            <div class=""icon""><i class=""icofont-newspaper""></i></div>
                            <h4 class=""title"">");
#nullable restore
#line 15 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\Home\Index.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p class=\"description text-left pb-3\">");
#nullable restore
#line 16 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\Home\Index.cshtml"
                                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 760, "\"", 786, 2);
            WriteAttributeValue("", 767, "/Home/News/", 767, 11, true);
#nullable restore
#line 17 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 778, item.Id, 778, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""font-weight-bolder bx-underline text-muted font-italic"" style=""font-size:20px"">
                                Read More  <i class=""icofont-arrow-right icofont-1x""></i>
                            </a>
                        </center>
                    </div>
                </div>
");
#nullable restore
#line 23 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
