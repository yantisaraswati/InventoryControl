#pragma checksum "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fa7dc30d9426f87cb9cc13f9753c27f942bbcff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_INV_Views_Permintaan_Index), @"mvc.1.0.view", @"/Areas/INV/Views/Permintaan/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fa7dc30d9426f87cb9cc13f9753c27f942bbcff", @"/Areas/INV/Views/Permintaan/Index.cshtml")]
    public class Areas_INV_Views_Permintaan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InventoryControl.Models.RequestHeader>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
  
    ViewData["Title"] = "Permintaan Bidang";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Koordinator</th>\r\n            <th>Status</th>\r\n            <th>Dibuat Tanggal</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
                 if (item.StatusId == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge-danger\">Usulan</span></td>\r\n");
#nullable restore
#line 24 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
                }
                else if (item.StatusId == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge-success\">Disetujui</span></td>\r\n");
#nullable restore
#line 28 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 29 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
               Write(item.CreatedDate?.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Permintaan\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InventoryControl.Models.RequestHeader>> Html { get; private set; }
    }
}
#pragma warning restore 1591
