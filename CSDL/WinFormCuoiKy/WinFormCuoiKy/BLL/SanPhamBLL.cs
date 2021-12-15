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
   public class SanPhamBLL
    {
        public static List<SanPham> GetAll()
        {
            QLBXModel context = new QLBXModel();
            return context.SanPhams.ToList();
        }
        public static void InsertUpdate(string MaXe, string TenXe, string HangXe,
            DateTime? NamSanXuat, long? DonGia, byte[] HinhAnh)
        {
            QLBXModel context = new QLBXModel();
            SanPham sp = new SanPham();
            sp.MaXe = MaXe;
            sp.TenXe = TenXe;
            sp.HangXe = HangXe;
            sp.NamSanXuat = NamSanXuat;
            sp.DonGia = DonGia;
            sp.HinhAnh = HinhAnh;
            context.SanPhams.AddOrUpdate(sp);
            context.SaveChanges();
        }
        public static void Delete(string MaXe)
        {
            QLBXModel context = new QLBXModel();
            SanPham sp = context.SanPhams.Where(p => p.MaXe == MaXe).FirstOrDefault();
            try
            {
                context.SanPhams.Remove(sp);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Có lỗi!");
            }
        }
        public static List<SanPham> TimKiem(string hoten)
        {
            QLBXModel context = new QLBXModel();

            // List<NhanVien> list = context.NhanViens.Where(p => (p is NhanVien) && (p as NhanVien).HoTen.ToLower().Contains(hoten.ToLower())).ToList();
            List<SanPham> list = context.SanPhams.Where(p => p.HangXe.ToLower().Contains(hoten.ToLower())).ToList();

            return list.ToList();
        }
    }
}
