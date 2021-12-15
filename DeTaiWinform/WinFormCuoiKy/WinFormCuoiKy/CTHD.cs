using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class CTHD : Form
    {
        public CTHD()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            try
            { 
                dgvCTHD.AutoGenerateColumns = false;
                dgvCTHD.DataSource = ChiTietHoaDonBLL.GetAll();
                cbxMaXe.DataSource = SanPhamBLL.GetAll();
                cbxMaXe.DisplayMember = "MaXe";
                cbxMaXe.ValueMember = "MaXe";
            }
            catch (SqlException e)
            {
                MessageBox.Show("Có lỗi " + e.Message);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }
        }

        private void btnSoLuongHD_Click(object sender, EventArgs e)
        {
            int sc = dgvCTHD.Rows.Count;
            txtSoLuongHD.Text = sc.ToString();
        }

        private void btnSoLuongXe_Click(object sender, EventArgs e)
        {
            int sc = dgvCTHD.Rows.Count;
            
            int tongxe = 0;
            for (int i = 0; i < sc ; i++)
            {
                tongxe += int.Parse(dgvCTHD.Rows[i].Cells[2].
                    Value.ToString());
            }
            txtSoLuongXe.Text = tongxe.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn chắc là muốn cập nhật?", "Thông báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                try
                {
                    ChiTietHoaDonBLL.InsertUpdate(txtMaHD.Text, cbxMaXe.Text, int.Parse(txtSoLuong.Text));
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
                   ChiTietHoaDonBLL.Delete(txtMaHD.Text,cbxMaXe.Text);
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

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCTHD.CurrentCell.RowIndex;
            txtMaHD.Text = dgvCTHD.Rows[r].Cells[0].Value.ToString();
            cbxMaXe.Text = dgvCTHD.Rows[r].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvCTHD.Rows[r].Cells[2].Value.ToString();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            DataBind();
        }

      
    }
}
