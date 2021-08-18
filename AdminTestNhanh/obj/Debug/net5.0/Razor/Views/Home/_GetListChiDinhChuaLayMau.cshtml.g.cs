#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e97b3c8b25884e5e4f2a9e1e533badb5abe944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GetListChiDinhChuaLayMau), @"mvc.1.0.view", @"/Views/Home/_GetListChiDinhChuaLayMau.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e97b3c8b25884e5e4f2a9e1e533badb5abe944", @"/Views/Home/_GetListChiDinhChuaLayMau.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42bf81ea4ac6a7dee730c18c40ff7051721c592", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GetListChiDinhChuaLayMau : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LayMauTestNhanh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
  
    var stt = 1;
    //var codeXn = ViewBag.CodeXn;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
        
    </div>
</div>

<br/>

<div class=""row"">
    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
        <div class=""float-right"">
            <button id=""btnXemDanhSachChuaLayMau"" class=""btn btn-primary"">Xem danh sách</button>
        </div>

        <table id=""tblDanhSachLayMau"" class=""table display table-striped table-bordered"" style=""width:100%; font-size: 13px; color: black"">
            <thead>
                <tr class=""text-center"">
                    <th>STT</th>
                    <th>Mã Y tế</th>
                    <th>Họ tên</th>
                    <th>Năm sinh</th>
                    <th>Giới tính</th>
                    <th>Điện thoại</th>

                    <th style=""width: 10%"">Tên chỉ định</th>
                    <th style=""width: 10%"">Thời gian chỉ định</th>
");
            WriteLiteral("                    \r\n                    <th style=\"width: 10%\">Đối tượng</th>\r\n                    <th>Ghi chú</th>\r\n");
            WriteLiteral("\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 52 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                 foreach (var item in Model.OrderBy(m => m.ThoiGian))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 55 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                        Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 56 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                                                              Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 57 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                                                              Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 58 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                                                              Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 60 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                             if (item.GioiTinh == "F")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>Nữ</p>\r\n");
#nullable restore
#line 63 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>Nam</p>\r\n");
#nullable restore
#line 67 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 69 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                       Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                       Write(item.DichVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                       Write(item.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        \r\n                        <td>\r\n");
#nullable restore
#line 81 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                             if (item.ThanhToan == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span title=\"Theo yêu cầu\" class=\"btn btn-info\">\r\n                                <i class=\"fas fa-dollar-sign\"></i>\r\n                            </span>\r\n");
#nullable restore
#line 86 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 89 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                             if (item.GhiChu == "null" || item.GhiChu is null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span></span>\r\n");
#nullable restore
#line 92 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }
                            else if (item.GhiChu.Contains("2"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Cổng số 2</span>\r\n");
#nullable restore
#line 96 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }
                            else if (item.GhiChu == "3")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Cổng số 3</span>\r\n");
#nullable restore
#line 100 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }
                            else if (item.GhiChu == "4")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Cổng số 4</span>\r\n");
#nullable restore
#line 104 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }
                            else if (item.GhiChu == "5")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Cổng số 5</span>\r\n");
#nullable restore
#line 108 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }
                            else if (item.GhiChu.ToLower() == "ck")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Hợp đồng công ty</span>\r\n");
#nullable restore
#line 112 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span></span>\r\n");
#nullable restore
#line 116 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 125 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListChiDinhChuaLayMau.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"    <script>
        
        function LayMau(id, YeuCauChiTiet_Id, nguoilaymau) {
            //disable onclick
            $(""#span_"" + id).removeAttr(""onclick"");            
            var congTy = """";
            var congSo2 = """";
            if ($(""#ckTenCongTy"").is("":checked"")) {
                congTy = '1';
            } else {
                congTy = '0'
            }

            if ($(""#ckCongSo2"").is("":checked"")) {
                congSo2 = '1';
            } else {
                congSo2 = '0'
            }

            $.ajax({
                type: ""GET"",
                url: ""/Home/Insert"",
                //data: JSON.stringify(objArr),
                data: { 'id': id, 'YeuCauChiTiet_Id': YeuCauChiTiet_Id, 'nguoilaymau': nguoilaymau },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (responses) {
                    if (responses === 1 || responses === ""1"") {
                 ");
            WriteLiteral(@"       swal.fire(""Lấy mẫu thành công"");
                        GetListChiDinhChuaLayMau(congTy, congSo2);
                        //GetListChiDinhDaLayMau();
                    } else {
                        swal.fire(""Thêm dữ liệu bị lỗi"");
                    }
                },
                failure: function (response) {
                    alert(""failure: GetListLayMauTestNhanh"" + response.responseText);
                },
                error: function (response) {
                    alert(""error: GetListLayMauTestNhanh"" + response.responseText);
                }
            });
        }

        $(document).ready(function () {
            $('#tblDanhSachLayMau').DataTable();

            $(""#btnXemDanhSachChuaLayMau"").click(function () {
                if ($(""#ckTenCongTy"").is("":checked"") && $(""#ckCongSo2"").is("":checked"")) {
                    GetListChiDinhChuaLayMau('1','1');
                }
                else if ($(""#ckTenCongTy"").is("":checked"") && !$(""#ckCong");
            WriteLiteral(@"So2"").is("":checked"")) {
                    GetListChiDinhChuaLayMau('1', '0');
                }
                else if (!$(""#ckTenCongTy"").is("":checked"") && $(""#ckCongSo2"").is("":checked"")) {
                    GetListChiDinhChuaLayMau('0', '1');
                }
                else {
                    GetListChiDinhChuaLayMau('0','0');
                }
            });
            //$(""#span_"" + id).click(function () {
            //    alert(id);
            //});
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LayMauTestNhanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
