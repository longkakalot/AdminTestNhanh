using AdminTestNhanh.Models;
using AdminTestNhanh.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTestNhanh.Repository
{
    public class AdminRepo : IAdminRepo
    {
        private readonly IDapperService _dapper;
        private readonly ILogger<AdminRepo> _logger;
        public AdminRepo(IDapperService dapper, ILogger<AdminRepo> logger, ILoggerFactory logFactory)
        {
            _logger = logger;
            _dapper = dapper;
            _logger = logFactory.CreateLogger<AdminRepo>();
        }

        public async Task<IList<LayMauTestNhanh>> GetListChuaLayMau(string tuNgay, string denNgay, string query)
        {
            try
            {
                string text = File.ReadAllText(query);
                var sql = String.Format(text, tuNgay, denNgay);

                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListChuaLayMau AdminRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<LayMauTestNhanh>> GetListDaLayMau(string tuNgay, string denNgay, string query)
        {
            try
            {
                string text = File.ReadAllText(query);
                var sql = String.Format(text, tuNgay, denNgay);

                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListDaLayMau AdminRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<LayMauTestNhanh>> GetListChuaKetQua(string tuNgay, string denNgay, string query)
        {
            try
            {
                string text = File.ReadAllText(query);
                var sql = String.Format(text, tuNgay, denNgay);

                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListChuaKetQua AdminRepo" + ex.Message);
                return null;
            }
        }

        

        public async Task<IList<LayMauTestNhanh>> GetListDaKetQua(string tuNgay, string denNgay, string query)
        {
            try
            {
                string text = File.ReadAllText(query);
                var sql = String.Format(text, tuNgay, denNgay);

                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListDaKetQua AdminRepo" + ex.Message);
                return null;
            }
        }

        

        public async Task<int> UpdateKetQua(int id, bool ketQua, string query)
        {
            try
            {                
                string text = File.ReadAllText(query);

                var sql = String.Format(text, ketQua, id);

                var resultAwait = await _dapper.Update<int>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateKetQua KetQuaRepo" + ex.Message);
                return 0;
            }
        }

        public async Task<int> HuyKetQua(int id, string query)
        {
            try
            {
                string text = File.ReadAllText(query);

                var sql = String.Format(text, id);

                var resultAwait = await _dapper.Update<int>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("HuyKetQua KetQuaRepo" + ex.Message);
                return 0;
            }
        }

        public async Task<IList<KetQua>> GetListKetQuaReport(string tuNgay, string denNgay, string query)
        {
            try
            {
                string text = File.ReadAllText(query);
                var sql = String.Format(text, tuNgay, denNgay);

                var resultAwait = await _dapper.GetAll<KetQua>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListDaKetQua AdminRepo" + ex.Message);
                return null;
            }
        }
    }
}
