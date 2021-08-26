using AdminTestNhanh.Models;
using AdminTestNhanh.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTestNhanh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IAdminRepo _iAdminRepo;
        
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env
             , IAdminRepo iAdminRepo)
        {
            _logger = logger;
            _env = env;
            _iAdminRepo = iAdminRepo;            
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetListChiDinhChuaLayMau(string tenCongTy, string congSo2, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var query = System.IO.Path.Combine(_env.WebRootPath, "Query\\GetListChuaLayMau.txt");


                var resultAwait = await _iAdminRepo.GetListChuaLayMau(tuNgay1, denNgay1, query);

                if (tenCongTy == "0" && congSo2 == "0") //ds không có hợp đồng, ko có số 2
                {
                    var result = resultAwait
                    .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")
                    || m.GhiChu.ToLower().Contains("nv")
                    || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                    .ToList();                    

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0") // có cty, ko có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();                    

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
                else if (tenCongTy == "0" && congSo2 == "1") // ko có cty, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();                    

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }

                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();                    

                    return PartialView("_GetListChiDinhChuaLayMau", result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListChiDinhChuaLayMau HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> GetListDaLayMauChuaKq(string tenCongTy, string congSo2, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var query = System.IO.Path.Combine(_env.WebRootPath, "Query\\GetListChuaKetQua.txt");

                var resultAwait = await _iAdminRepo.GetListChuaKetQua(tuNgay1, denNgay1, query);

                if (tenCongTy == "0" && congSo2 == "0") //ds không có hợp đồng, ko có số 2
                {
                    var result = resultAwait
                    .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")
                    || m.GhiChu.ToLower().Contains("nv")
                    || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                    .ToList();

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0") // có cty, ko có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }
                else if (tenCongTy == "0" && congSo2 == "1") // ko có cty, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }

                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListDaLayMauChuaKq", result);
                }







                //if (tenCongTy == "0") //ds không có hợp đồng
                //{
                //    var result = resultAwait
                //        .Where(m => m.GhiChu is null)
                //        .ToList();                    

                //    return PartialView("_GetListDaLayMauChuaKq", result);
                //}
                //else
                //{
                //    var result = resultAwait
                //        .Where(m => m.TenCongTy is not null && m.GhiChu is not null)
                //        .ToList();                    

                //    return PartialView("_GetListDaLayMauChuaKq", result);
                //}


                //var result = resultAwait.ToList();

                //return PartialView("_GetListDaLayMauChuaKq", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListDaLayMauChuaKq KetQuaController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> GetListDaLayMauCoKq(string tenCongTy, string congSo2, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var query = System.IO.Path.Combine(_env.WebRootPath, "Query\\GetListDaKetQua.txt");

                var resultAwait = await _iAdminRepo.GetListDaKetQua(tuNgay1, denNgay1, query);

                if (tenCongTy == "0" && congSo2 == "0") //ds không có hợp đồng, ko có số 2
                {
                    var result = resultAwait
                    .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")
                    || m.GhiChu.ToLower().Contains("nv")
                    || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                    .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0") // có cty, ko có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }
                else if (tenCongTy == "0" && congSo2 == "1") // ko có cty, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }

                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu is not null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListDaLayMauCoKq", result);
                }

                //if (tenCongTy == "0") //ds không có hợp đồng
                //{
                //    var result = resultAwait
                //        .Where(m => m.GhiChu is null)
                //        .ToList();

                //    return PartialView("_GetListDaLayMauCoKq", result);
                //}
                //else
                //{
                //    var result = resultAwait
                //        .Where(m => m.TenCongTy is not null && m.GhiChu is not null)
                //        .ToList();

                //    return PartialView("_GetListDaLayMauCoKq", result);
                //}


                //var result = resultAwait.ToList();

                //return PartialView("_GetListDaLayMauCoKq", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListDaLayMauCoKq HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> UpdateKetQua(int Id, bool ketQua)
        {
            try
            {
                var thoiGian = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                var query = System.IO.Path.Combine(_env.WebRootPath, "Query\\UpdateKetQua.txt");

                bool KetQua = true;

                if (ketQua == true)
                {
                    KetQua = false;
                }

                var resultAwait = await _iAdminRepo.UpdateKetQua(Id, KetQua, query);
                var result = resultAwait;

                return Content(result.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogInformation("UpdateKetQua HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> HuyKetQua(int Id)
        {
            try
            {
                var thoiGian = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                var query = System.IO.Path.Combine(_env.WebRootPath, "Query\\HuyKetQua.txt");

                

                var resultAwait = await _iAdminRepo.HuyKetQua(Id, query);
                var result = resultAwait;

                return Content(result.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogInformation("UpdateKetQua HomeController" + ex.Message);
                return Content("0");
            }
        }


        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
