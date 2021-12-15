using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCuoiKy
{
    public partial class ManHinhChinh : Form
    {
        public static string role = "";
        public ManHinhChinh()
        {
            InitializeComponent();
            role = Program.role;
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien ttnv = new ThongTinNhanVien();
            flowLayoutPanel1.Controls.Clear();
            ttnv.TopLevel = false;
            flowLayoutPanel1.Controls.Add(ttnv);
            ttnv.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang ttkh = new ThongTinKhachHang();
            flowLayoutPanel1.Controls.Clear();
            ttkh.TopLevel = false;
            flowLayoutPanel1.Controls.Add(ttkh);
            ttkh.Show();
        }

        private void thôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSanPham ttsp = new ThongTinSanPham();
            flowLayoutPanel1.Controls.Clear();
            ttsp.TopLevel = false;
            flowLayoutPanel1.Controls.Add(ttsp);
            ttsp.Show();
        }

        private void thongTinHoaDonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon tthd = new ThongTinHoaDon();
            flowLayoutPanel1.Controls.Clear();
            tthd.TopLevel = false;
            flowLayoutPanel1.Controls.Add(tthd);
            tthd.Show();
        }

        private void chiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTHD cthd = new CTHD();
            flowLayoutPanel1.Controls.Clear();
            cthd.TopLevel = false;
            flowLayoutPanel1.Controls.Add(cthd);
            cthd.Show();
        }

        private void thốngKêSốLượngXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ThongKeLuong tkl = new ThongKeLuong();
            flowLayoutPanel1.Controls.Clear();
            tkl.TopLevel = false;
            flowLayoutPanel1.Controls.Add(tkl);
            tkl.Show();
        }

        private void thốngKêDoanhThuBánXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDoanhSo tkds = new ThongKeDoanhSo();
            flowLayoutPanel1.Controls.Clear();
            tkds.TopLevel = false;
            flowLayoutPanel1.Controls.Add(tkds);
            tkds.Show();
        }

       

      
        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không ?", "Thông báo",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taikhoan tk = new Taikhoan();
            tk.Show();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            if (role == "2")
            {
                tàiKhoảnToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                báoCáoToolStripMenuItem.Visible = false;
            }
        }
    }
}
