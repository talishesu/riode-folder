#pragma checksum "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\Colors\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c77a07db918ebc8449731607544b273bc7d4e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Colors_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Colors/Detail.cshtml")]
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
#line 2 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\_ViewImports.cshtml"
using riode.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\_ViewImports.cshtml"
using riode;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c77a07db918ebc8449731607544b273bc7d4e8b", @"/Areas/Admin/Views/Colors/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56e9c2efc69d5fb98da8eacaf59aef435e7c7ae", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Colors_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<riode.Models.Entities.Colors>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\Colors\Detail.cshtml"
  
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
                            <th>Color</th>
                            <th>Name</th>
                            <th>Color Code</th>
                            <th>Created Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">");
#nullable restore
#line 23 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\Colors\Detail.cshtml"
                                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td><div");
            BeginWriteAttribute("style", " style=\"", 802, "\"", 867, 3);
            WriteAttributeValue("", 810, "background-color:", 810, 17, true);
#nullable restore
#line 24 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\Colors\Detail.cshtml"
WriteAttributeValue("", 827, Model.ColorCode, 827, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 843, ";width:20px;height:20px;", 843, 24, true);
            EndWriteAttribute();
            WriteLiteral("></div></td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\Colors\Detail.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\Colors\Detail.cshtml"
                           Write(Model.ColorCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\quliy\source\repos\riode-folder\riode\Areas\Admin\Views\Colors\Detail.cshtml"
                           Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<riode.Models.Entities.Colors> Html { get; private set; }
    }
}
#pragma warning restore 1591
