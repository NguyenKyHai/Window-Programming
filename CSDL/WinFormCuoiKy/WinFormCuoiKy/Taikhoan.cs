using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCuoiKy.BLL;
using WinFormCuoiKy.Model;

namespace WinFormCuoiKy
{
    public partial class Taikhoan : Form
    {
        public Taikhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            dgvTaiKhoan.DataSource = TaiKhoanBLL.GetAll();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTaiKhoan.CurrentCell.RowIndex;
            txtTaiKhoan.Text = dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[r].Cells[1].Value.ToString();
            string quyen = dgvTaiKhoan.Rows[r].Cells[2].Value.ToString();
            if (quyen == "1") txtQuyen.Text = "Giám đốc";
            else txtQuyen.Text = "Nhân viên";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn chắc là muốn cập nhật?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                try
                {
                    TaiKhoanBLL.InsertUpdate(txtTaiKhoan.Text, txtMatKhau.Text, txtQuyen.Text);
                    DataBind();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message);
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn chắc là muốn xóa?", "Thông báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                try
                {
                    TaiKhoanBLL.Delete(txtTaiKhoan.Text);
                    DataBind();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message);
                }
                catch
                {
                    MessageBox.Show("Không xóa được");
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
