#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae5e9ccd46310de4611915c4c1244f9a3a1bae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GetListDaLayMauChuaKq), @"mvc.1.0.view", @"/Views/Home/_GetListDaLayMauChuaKq.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae5e9ccd46310de4611915c4c1244f9a3a1bae9", @"/Views/Home/_GetListDaLayMauChuaKq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42bf81ea4ac6a7dee730c18c40ff7051721c592", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GetListDaLayMauChuaKq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LayMauTestNhanh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
  
    var stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""float-right"">
    <button id=""btnXemDanhSach"" class=""btn btn-primary"">Xem danh sách</button>
</div>

<table id=""tblDanhSachChuaKetQua"" class=""table display table-striped table-bordered"" style=""width:100%; font-size: 13px; color: black"">
    <thead>
        <tr class=""text-center"">
            <th style=""width: 5%"">STT</th>
            <th style=""width: 5%"">Mã Y tế</th>
            <th style=""width: 10%"">Họ tên</th>
            <th style=""width: 5%"">Năm sinh</th>
            <th style=""width: 5%"">Giới tính</th>
            <th style=""width: 10%"">Điện thoại</th>
            <th style=""width: 10%"">Tên chỉ định</th>
            <th style=""width: 10%"">Thời gian lấy mẫu</th>
            <th style=""width: 20%"">Đối tượng</th>

");
            WriteLiteral("            <th>Ghi chú</th>\r\n            <th>Xử lý</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
         foreach (var item in Model.OrderBy(m=>m.ThoiGian))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 43 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
            Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 44 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                                                  Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 45 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                                                  Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 46 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                                                  Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 48 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                 if (item.GioiTinh == "F")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nữ</p>\r\n");
#nullable restore
#line 51 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nam</p>\r\n");
#nullable restore
#line 55 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 57 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
           Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
           Write(item.DichVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
           Write(item.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 61 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                 if (item.ThanhToan == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-info\">Theo Yêu cầu</span>\r\n");
#nullable restore
#line 64 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n");
            WriteLiteral("            <td>\r\n");
#nullable restore
#line 79 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                 if (item.GhiChu == "null" || item.GhiChu is null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span></span>\r\n");
#nullable restore
#line 82 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.Contains("2"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 2</span>\r\n");
#nullable restore
#line 86 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu == "3")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 3</span>\r\n");
#nullable restore
#line 90 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu == "4")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 4</span>\r\n");
#nullable restore
#line 94 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu == "5")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 5</span>\r\n");
#nullable restore
#line 98 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else if (item.GhiChu.ToLower() == "ck")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Hợp đồng công ty</span>\r\n");
#nullable restore
#line 102 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span></span>\r\n");
#nullable restore
#line 106 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n            <td>\r\n                Hủy lấy mẫu\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 112 "G:\SourceCodeWebApp\XNTestNhanhCovid\Admin\AdminTestNhanh\AdminTestNhanh\Views\Home\_GetListDaLayMauChuaKq.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"    <script>
        function UpdateLis(id, nhapLis) {
            $.ajax({
                type: ""GET"",
                url: ""/ketqua/UpdateLis"",
                //data: JSON.stringify(objArr),
                data: { 'id': id, 'nhapLis': nhapLis },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (responses) {
                    if (responses === 1 || responses === ""1"") {
                        GetListChuaNhapLis();
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

        function InsertKetQua(id, ke");
            WriteLiteral(@"tqua) {
            var userId = $(""#slNguoiKetQua option:selected"").val();
            console.log(userId);
            if (userId === 0 || userId === ""0"") {
                swal.fire(""Chưa chọn người trả kết quả"");
                return false;
            }
            else {
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
                    url: ""/Home/InsertKetQua"",
                    //data: JSON.stringify(objArr),
                    data: { 'id': id, 'ketqua': ketqua, 'NguoiKetQua': userId },
                    //contentType: ""application/json; charset=utf-8"",
       ");
            WriteLiteral(@"             dataType: ""text"",
                    success: function (responses) {
                        if (responses === 1 || responses === ""1"") {
                            swal.fire(""Cập nhật kết quả thành công"");
                            GetListDaLayMauChuaKq(congTy, congSo2);
                            GetListDaLayMauCoKq(congTy, congSo2);


                            //GetListDaLayMauChuaKq();
                            //GetListDaLayMauCoKq();
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
            
        }
");
            WriteLiteral(@"

        $(document).ready(function () {
            
            

            $('#tblDanhSachChuaKetQua').DataTable();

            $(""#btnXemDanhSach"").click(function () {
                if ($(""#ckTenCongTy"").is("":checked"") && $(""#ckCongSo2"").is("":checked"")) {
                    GetListDaLayMauChuaKq('1', '1');
                }
                else if ($(""#ckTenCongTy"").is("":checked"") && !$(""#ckCongSo2"").is("":checked"")) {
                    GetListDaLayMauChuaKq('1', '0');
                }
                else if (!$(""#ckTenCongTy"").is("":checked"") && $(""#ckCongSo2"").is("":checked"")) {
                    GetListDaLayMauChuaKq('0', '1');
                }
                else {
                    GetListDaLayMauChuaKq('0', '0');
                }


                //if ($(""#ckTenCongTy"").is("":checked"")) {
                //    GetListDaLayMauChuaKq('1');
                //} else {
                //    GetListDaLayMauChuaKq('0');
                //}


                //Ge");
            WriteLiteral("tListDaLayMauChuaKq();\r\n                \r\n            });            \r\n        });\r\n    </script>\r\n");
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