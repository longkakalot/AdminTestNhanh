#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\BaoCao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d6cf9ed52b64766b673e317e5beb7dfd097f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoCao_Index), @"mvc.1.0.view", @"/Views/BaoCao/Index.cshtml")]
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
#line 1 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\_ViewImports.cshtml"
using AdminTestNhanh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\_ViewImports.cshtml"
using AdminTestNhanh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d6cf9ed52b64766b673e317e5beb7dfd097f2a", @"/Views/BaoCao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42bf81ea4ac6a7dee730c18c40ff7051721c592", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoCao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\BaoCao\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header bg-info"" style=""padding-bottom: 0px; padding-top: 5px"">
        <div class=""row"">
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-6"">
                <h5 class=""card-title text-white"">
                    Báo cáo những ca test nhanh dương tính
                </h5>
            </div>
            
        </div>
    </div>   
    

    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-4"">
                <div class=""form-group"">
                    <div class=""form-inline"">
                        <span>Từ ngày: </span>
                        <input type=""date"" id=""dtTuNgay"" class=""form-control ml-2""");
            BeginWriteAttribute("value", " value=\"", 788, "\"", 832, 1);
#nullable restore
#line 24 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\BaoCao\Index.cshtml"
WriteAttributeValue("", 796, DateTime.Now.ToString("yyyy-MM-dd"), 796, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                </div>
            </div>
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-4"">
                <div class=""form-group"">
                    <div class=""form-inline"">
                        <span>Đến ngày: </span>
                        <input type=""date"" id=""dtDenNgay"" class=""form-control ml-2""");
            BeginWriteAttribute("value", " value=\"", 1194, "\"", 1238, 1);
#nullable restore
#line 32 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\BaoCao\Index.cshtml"
WriteAttributeValue("", 1202, DateTime.Now.ToString("yyyy-MM-dd"), 1202, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        <input type=""button"" id=""btnLayBaoCao"" class=""btn btn-primary"" value=""Lấy báo cáo"" />
                    </div>
                </div>
            </div>
        </div>

        <hr />

        <div id=""divDanhSachKetQua""></div>
    </div>


</div>




");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function GetListKetQuaReport() {
                var tuNgay = $(""#dtTuNgay"").val();
                var denNgay = $(""#dtDenNgay"").val();
                $.ajax({
                    type: ""GET"",
                    url: ""/BaoCao/GetListKetQuaReport"",
                    //data: JSON.stringify(objArr),
                    data: { 'tuNgay': tuNgay, 'denNgay': denNgay },
                    //contentType: ""application/json; charset=utf-8"",
                    dataType: ""text"",
                    success: function (responses) {
                        if (responses === 0 || responses === ""0"") {
                            swal.fire(""Không lấy được thông tin"");
                        } else {
                            $(""#divDanhSachKetQua"").html(responses);
                        }
                    },
                    failure: function (response) {
                        alert(""failure: GetListKetQuaReport"" + response.responseText);
                    },
  ");
                WriteLiteral(@"                  error: function (response) {
                        alert(""error: GetListKetQuaReport"" + response.responseText);
                    }
                });
            }

            
            $(document).ready(function () {
                $(""#btnLayBaoCao"").click(function () {
                    GetListKetQuaReport();
                });
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591