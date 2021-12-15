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
   public class ChiTietHoaDonBLL
    {
        public static List<ChiTietHoaDon> GetAll()
        {
            QLBXModel context = new QLBXModel();
            return context.ChiTietHoaDons.ToList();
        }
        public static void InsertUpdate(string MaHD, string MaXe, int? Soluong)
        {
            QLBXModel context = new QLBXModel();
            ChiTietHoaDon ct = new ChiTietHoaDon();
            ct.MaHD = MaHD;
            ct.MaXe = MaXe;
            ct.Soluong = Soluong;
            context.ChiTietHoaDons.AddOrUpdate(ct);
            context.SaveChanges();
        }
        public static void Delete(string MaHD,string MaXe)
        {
            QLBXModel context = new QLBXModel();
            ChiTietHoaDon ct = context.ChiTietHoaDons.Where(p => p.MaHD == MaHD && p.MaXe==MaXe).FirstOrDefault();
            try
            {
                context.ChiTietHoaDons.Remove(ct);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Có lỗi!");
            }
        }

    }
}
