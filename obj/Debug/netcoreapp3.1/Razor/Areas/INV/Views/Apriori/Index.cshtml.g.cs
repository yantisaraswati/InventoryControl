#pragma checksum "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed72ec10e3747bebb2f78c9835bddc33b81e55c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_INV_Views_Apriori_Index), @"mvc.1.0.view", @"/Areas/INV/Views/Apriori/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed72ec10e3747bebb2f78c9835bddc33b81e55c", @"/Areas/INV/Views/Apriori/Index.cshtml")]
    public class Areas_INV_Views_Apriori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventoryControl.Areas.INV.Models.AprioriViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
  
    ViewData["Title"] = "Proses Apriori";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><i class=\"fa fa-cog fa-spin\"></i> ");
#nullable restore
#line 8 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
                                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <div class=\"card-form\">\r\n            <div class=\"card-label _20\">Min Support </div>\r\n            <div class=\"form-control _80\">\r\n                : <input type=\"text\" id=\"txt-minsupport\"");
            BeginWriteAttribute("value", " value=\"", 523, "\"", 548, 1);
#nullable restore
#line 15 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
WriteAttributeValue("", 531, Model.MinSupport, 531, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-form\">\r\n            <div class=\"card-label _20\">Min Confidence </div>\r\n            <div class=\"form-control _80\">\r\n                : <input type=\"text\" id=\"txt-minconfidence\"");
            BeginWriteAttribute("value", " value=\"", 788, "\"", 816, 1);
#nullable restore
#line 21 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
WriteAttributeValue("", 796, Model.MinConfidence, 796, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-form\">\r\n            <div class=\"card-label _20\">Bidang </div>\r\n            <div class=\"form-control _80\">\r\n                : ");
#nullable restore
#line 27 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
             Write(Html.DropDownList("KdOrg", new SelectList(ViewBag.SelectBidang, "Id", "Nama")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""card-form"">
            <div class=""card-label _20""></div>
            <div class=""card-label _80"">
                <div style=""flex"">
                    <button type=""button"" class=""btn btn-success"" id=""btn-show"">Lihat Data</button>
                    <button type=""button"" class=""btn btn-info"" id=""btn-proses"">Proses Dengan Apriori</button>
                </div>
                
            </div>
        </div>
    </div>
</div>

<div class=""alert-danger"" style=""display:none;"">
    <i class=""fa fa-warning""></i> Peringatan!<br />
    <div class=""alert-body"">Test</div>
</div>

<div class=""card"">
    <div class=""card-header"">
        <div class=""card-title"">
            <h2>Support Count</h2>
        </div>
    </div>
    <div class=""card-body"" id=""tbl-support"">
        
    </div>
</div>
<div class=""card"">
    <div class=""card-header"">
        <div class=""card-title"">
            <h2>Association Rules</h2>
        </di");
            WriteLiteral("v>\r\n    </div>\r\n    <div class=\"card-body\" id=\"tbl-rules\">\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .card-form {
            display: flex;
            margin-bottom: 10px;
        }

        ._20 {
            width: 20%;
        }

        .form-control {
            display: block;
            width: 100%;
        }

        .btn {
            height: 40px;
            color: #ffffff;
            background-color: #86134c;
            padding: 5px 10px 5px 10px;
            border-color: #86134c;
            border-radius: 25px;
        }

        .pager {
            margin-top: 40px;
        }

        .devider {
            margin-left: 20px;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        var defaultKdOrg = \"");
#nullable restore
#line 106 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
                       Write(Model.DefaultKdOrg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        var minSupport = parseInt(\"");
#nullable restore
#line 107 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
                              Write(Model.MinSupport);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n        var minConfidence = parseInt(\"");
#nullable restore
#line 108 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
                                 Write(Model.MinConfidence);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");

        getSupport(minSupport, minConfidence, defaultKdOrg);
        getRules(defaultKdOrg);

        $(""#btn-show"").click(function () {
            var minsupport = $(""#txt-minsupport"").val();
            var minconfidence = $(""#txt-minconfidence"").val();
            var kdOrg = $(""#KdOrg"").val();
            getSupport(minSupport, minConfidence, kdOrg);
            getRules(kdOrg);
        });

        $(""#btn-proses"").click(function () {
            var minsupport = $(""#txt-minsupport"").val();
            var minconfidence = $(""#txt-minconfidence"").val();
            var kdOrg = $(""#KdOrg"").val();

            console.log(minsupport);
            if (minsupport == null || minsupport == """" || minconfidence == null || minconfidence == """" || kdOrg == null || kdOrg == """") {
                alert(""Minimum Support, Minimum Confidence, dan Bidang harus diisi!"");
            } else {
                console.log(""Silakan tunggu..........."");
                //showLoadPanel();
          ");
                WriteLiteral(@"      showBusyIndicator(""body"");
                $.ajax({
                    url: '/INV/ApiApriori/ProsesApriori/',
                    method: ""POST"",
                    data:
                    {
                        minsupport: minsupport,
                        minconfidence: minconfidence,
                        kdOrg: kdOrg,
                        isForce: true
                    },
                    error: function (request, status, error) {
                        stopBusyIndicator();
                        $("".alert-body"").html(error);
                        $("".alert-danger"").show();
                    }
                })
                .done(function (result) {
                    stopBusyIndicator();
                    console.log(result);
                    $(""#tbl-support"").html(result);

                    //if (result) {
                    //    result.forEach(function (item) {

                    //        $(""#tbl-support"").append(""<tr><td>"" + $(");
                WriteLiteral(@"""#KdOrg option:selected"").text() + ""</td><td>"" + item.startDate + ""</td><td>"" + item.itemList + ""</td><td>"" + item.label + ""</td><td>"" + item.support + ""</td></tr>"");
                    //    })
                    //}
                    

                    getRules(kdOrg);
                });
            }

        });

        $(""#");
#nullable restore
#line 168 "D:\KULIAH\Skripsi\Project\InventoryControl\Areas\INV\Views\Apriori\Index.cshtml"
       Write(ViewBag.ActiveClass);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""").addClass(""active"");

        function getSupport(minSupport, minConfidence, kdOrg) {
            //showBusyIndicator(""body"");
            $.ajax({
                url: '/INV/ApiApriori/GetSupport/',
                method: ""GET"",
                data:
                {
                    minSupport: minSupport,
                    minConfidence: minConfidence,
                    kdOrg: kdOrg
                }
            })
                .done(function (result) {
                    //stopBusyIndicator();
                    console.log(result);
                    $(""#tbl-support"").html("""");
                    $(""#tbl-support"").append(result);
                });
        }

        function getRules(kdOrg) {
            //showBusyIndicator(""body"");
            $.ajax({
                url: '/INV/ApiApriori/GetRules/',
                method: ""GET"",
                data:
                {
                    kdOrg: kdOrg
                }
            })
                ");
                WriteLiteral(@".done(function (result) {
                    //stopBusyIndicator();
                    console.log(result);
                    $(""#tbl-rules"").html("""");
                    $(""#tbl-rules"").append(result);
                });
        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryControl.Areas.INV.Models.AprioriViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
