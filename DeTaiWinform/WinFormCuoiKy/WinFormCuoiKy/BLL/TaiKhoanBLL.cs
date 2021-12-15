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
    public class TaiKhoanBLL
    {
        public static List<TaiKhoan> GetAll()
        {
            QLBXModel context = new QLBXModel();
            return context.TaiKhoans.ToList();
        }
        public static void InsertUpdate(string tk, string mk, string role)
        {
            QLBXModel context = new QLBXModel();
            TaiKhoan t = new TaiKhoan();
            t.id = tk;
            t.pass = mk;
            t.role = role;
            context.TaiKhoans.AddOrUpdate(t);
            context.SaveChanges();
        }
        public static void Delete(string tk)
        {
            QLBXModel context = new QLBXModel();
            TaiKhoan t = context.TaiKhoans.Where(p => p.id == tk).FirstOrDefault();
            try
            {
                context.TaiKhoans.Remove(t);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Có lỗi!");
            }
        }
    }
}
