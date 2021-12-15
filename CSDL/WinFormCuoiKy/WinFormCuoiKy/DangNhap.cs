using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCuoiKy.Model;

namespace WinFormCuoiKy
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            QLBXModel context = new QLBXModel();
            string tk = txtTaiKhoan.Text.ToString();
            string mk = txtMatKhau.Text.ToString();
           
            var check = context.TaiKhoans.Where(p => p.id.Equals(tk)).ToList();
            if (check.Count > 0)
            {
                if (check[0].pass.Equals(mk))
                {
                    Program.role = check[0].role.ToString();
                    MessageBox.Show("Đăng nhập thành công");
                    ManHinhChinh mhc = new ManHinhChinh();
                    mhc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mat khau khong dung!");
                }
            }
            else
            {
                MessageBox.Show("Khong ton tai tai khoan!");
            }
        }
    }
}
