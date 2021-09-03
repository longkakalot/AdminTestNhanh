using AdminTestNhanh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTestNhanh.Repository
{
    public interface IAdminRepo
    {
        Task<IList<LayMauTestNhanh>> GetListChuaLayMau(string tuNgay, string denNgay, string query);
        Task<IList<LayMauTestNhanh>> GetListDaLayMau(string tuNgay, string denNgay, string query);
        Task<IList<LayMauTestNhanh>> GetListChuaKetQua(string tuNgay, string denNgay, string query);
        Task<IList<LayMauTestNhanh>> GetListDaKetQua(string tuNgay, string denNgay, string query);
        Task<int> UpdateKetQua(int id, bool ketQua, string query);
        Task<int> HuyKetQua(int id, string query);
        Task<IList<KetQua>> GetListKetQuaReport(string tuNgay, string denNgay, string query);

    }
}
