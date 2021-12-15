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
   public class KhachHangBLL
    {
        public static List<KhachHang> GetAll()
        {
            QLBXModel context = new QLBXModel();
            return context.KhachHangs.ToList();
        }
        public static void InsertUpdate(string MaKH, string TenKH, string DiaChi, string ThanhPho, string SoDienThoai)
        {
            QLBXModel context = new QLBXModel();
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;
            kh.TenKH = TenKH;
            kh.DiaChi = DiaChi;
            kh.ThanhPho = ThanhPho;
            kh.SoDienThoai = SoDienThoai;
            context.KhachHangs.AddOrUpdate(kh);
            context.SaveChanges();
        }
        public static void Delete(string MaKh)
        {
            QLBXModel context = new QLBXModel();
            KhachHang kh = context.KhachHangs.Where(p => p.MaKH == MaKh).FirstOrDefault();
           
                context.KhachHangs.Remove(kh);
                context.SaveChanges();
           
          
        }
        public static List<KhachHang> TimKiem(string hoten)
        {
            QLBXModel context = new QLBXModel();

            List<KhachHang> list = context.KhachHangs.Where(p => (p is KhachHang) && (p as KhachHang).TenKH.ToLower().Contains(hoten.ToLower())).ToList();
            // List<KhachHang> list = context.KhachHangs.Where(p => p.TenKH.ToLower().Contains(hoten.ToLower())).ToList();

            return list.ToList();
        }
    }
}
