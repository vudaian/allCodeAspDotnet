#pragma checksum "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a871f7a2c25ccfabe255a3d5434d9f559608a0f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SinhVien_ShowStudent), @"mvc.1.0.view", @"/Views/SinhVien/ShowStudent.cshtml")]
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
#line 1 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\_ViewImports.cshtml"
using VuDaiAn_1405;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\_ViewImports.cshtml"
using VuDaiAn_1405.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a871f7a2c25ccfabe255a3d5434d9f559608a0f9", @"/Views/SinhVien/ShowStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8beaa10f5c22fba8112f315ee8abe48c29cf2ca", @"/Views/_ViewImports.cshtml")]
    public class Views_SinhVien_ShowStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VuDaiAn_1405.Models.SinhVien>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
  
    ViewData["Title"] = "ShowStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <h3>Danh sách sinh viên</h3>
    <a href=""/SinhVien/AddStudent"" class=""btn btn-success"">Thêm mới</a>
    <table class=""table table-bordered"">
        <thead>
            <th>Mã sinh viên</th>
            <th>Họ tên</th>
            <th>Tên lớp</th>
            <th>Địa chỉ</th>
            <th>Số điện thoại</th>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
                   Write(item.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
                   Write(item.NumBerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "D:\Workspace\C#\CNTT 14-05\VuDaiAn_1405\VuDaiAn_1405\Views\SinhVien\ShowStudent.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VuDaiAn_1405.Models.SinhVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
