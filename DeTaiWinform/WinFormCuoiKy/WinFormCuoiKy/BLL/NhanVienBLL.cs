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
    public class NhanVienBLL
    {
        public static List<NhanVien> GetAll()
        {
            QLBXModel context = new QLBXModel();
            return context.NhanViens.ToList();
        }
        public static void InsertUpdate(string MaNV, string HoTen, DateTime? NgaySinh, string GioiTinh, string DiaChi,
         string Email, string SoDienThoai, int? Luong, DateTime? NgayVaoLam, byte[] HinhAnh)
        {
            QLBXModel context = new QLBXModel();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.HoTen = HoTen;
            nv.NgaySinh = NgaySinh;
            nv.Gioitinh = GioiTinh;
            nv.DiaChi = DiaChi;
            nv.Email = Email;
            nv.SoDienThoai = SoDienThoai;
            nv.Luong = Luong;
            nv.NgayVaoLam = NgayVaoLam;
            nv.HinhAnh = HinhAnh;

            context.NhanViens.AddOrUpdate(nv);
            context.SaveChanges();
        }
        public static void Delete(string MaNV)
        {
            QLBXModel context = new QLBXModel();
            NhanVien nv = context.NhanViens.Where(p => p.MaNV == MaNV).FirstOrDefault();
            
                context.NhanViens.Remove(nv);
                context.SaveChanges();
          
        }
        public static List<NhanVien> TimKiem(string hoten)
        {
            QLBXModel context = new QLBXModel();

            // List<NhanVien> list = context.NhanViens.Where(p => (p is NhanVien) && (p as NhanVien).HoTen.ToLower().Contains(hoten.ToLower())).ToList();
            List<NhanVien> list = context.NhanViens.Where(p => p.HoTen.ToLower().Contains(hoten.ToLower())).ToList();

            return list.ToList();
        }

    }
}
