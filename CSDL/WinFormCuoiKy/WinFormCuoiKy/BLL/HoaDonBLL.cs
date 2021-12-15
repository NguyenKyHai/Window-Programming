using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCuoiKy.Model;

namespace WinFormCuoiKy.BLL
{
    public class HoaDonBLL
    {
        public static List<HoaDon> GetAll()
        {
            QLBXModel context = new QLBXModel();
            return context.HoaDons.ToList();
        }
        public static void InsertUpdate(string MaHD, string MaNV, string MaKH, DateTime? NgayLapHD, DateTime? NgayNhanHang)
        {
            QLBXModel context = new QLBXModel();
            HoaDon hd = new HoaDon();
            hd.MaHD = MaHD;
            hd.MaNV = MaNV;
            hd.MaKH = MaKH;
            hd.NgayLapHD = NgayLapHD;
            hd.NgayNhanHang = NgayNhanHang;
            context.HoaDons.AddOrUpdate(hd);
            context.SaveChanges();
        }
        public static void Delete(string MaHD)
        {
            QLBXModel context = new QLBXModel();
            HoaDon hd = context.HoaDons.Where(p => p.MaHD == MaHD).FirstOrDefault();
            try
            {
                context.HoaDons.Remove(hd);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Có lỗi!");
            }
        }
    }
}
