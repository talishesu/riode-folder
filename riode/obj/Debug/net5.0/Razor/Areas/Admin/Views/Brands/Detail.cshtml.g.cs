#pragma checksum "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\Brands\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f96517930b7fa020a64660f72b809318bd9473b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brands_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Brands/Detail.cshtml")]
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
#line 2 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\_ViewImports.cshtml"
using riode.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\_ViewImports.cshtml"
using riode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\_ViewImports.cshtml"
using riode.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f96517930b7fa020a64660f72b809318bd9473b1", @"/Areas/Admin/Views/Brands/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec9fe481ec5de4b9e85b24fd10994205e2b8ab5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brands_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<riode.Models.Entities.Brands>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\Brands\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""padding:0;margin-left:240px"">
    <div class=""card"">
        <div class=""card-block table-border-style"">
            <div class=""table-responsive"">
                <table class=""table table-inverse"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Name</th>
                            <th>Description</th>
                            <th>Created Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">");
#nullable restore
#line 22 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\Brands\Detail.cshtml"
                                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\Brands\Detail.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\Brands\Detail.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\CalenLoki\source\repos\riode-folder\riode\Areas\Admin\Views\Brands\Detail.cshtml"
                           Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        \r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<riode.Models.Entities.Brands> Html { get; private set; }
    }
}
#pragma warning restore 1591
