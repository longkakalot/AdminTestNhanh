using AdminTestNhanh.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTestNhanh.Controllers
{
    public class BaoCaoController : Controller
    {
        private readonly ILogger<BaoCaoController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IAdminRepo _iAdminRepo;

        public BaoCaoController(ILogger<BaoCaoController> logger, IWebHostEnvironment env
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

        public async Task<IActionResult> GetListKetQuaReport(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var query = System.IO.Path.Combine(_env.WebRootPath, "Query\\GetListKetQuaReport.txt");

                var resultAwait = await _iAdminRepo.GetListKetQuaReport(tuNgay1, denNgay1, query);

                var result = resultAwait.ToList();

                return PartialView("_GetListKetQuaReport", result);

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

    }
}
