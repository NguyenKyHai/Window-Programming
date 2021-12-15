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
    public partial class ThongTinHoaDon : Form
    {
        public ThongTinHoaDon()
        {
            InitializeComponent();
        }

        private void ThongTinHoaDon_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            try
            {
                dgvHoaDon.AutoGenerateColumns = false;
                dgvHoaDon.DataSource = HoaDonBLL.GetAll();
                cbxMaNV.DataSource = NhanVienBLL.GetAll();
                cbxMaNV.DisplayMember = "MaNV";
                cbxMaNV.ValueMember = "MaNV";
                cbxMaKH.DataSource = KhachHangBLL.GetAll();
                cbxMaKH.DisplayMember = "MaKH";
                cbxMaKH.ValueMember = "MaKH";
            }
            catch (SqlException e)
            {
                MessageBox.Show("Có lỗi " + e.Message);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            txtMaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            cbxMaNV.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            cbxMaKH.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            dtmNgayLapHD.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            dtmNgayNhanHang.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           DialogResult thongbao = MessageBox.Show("Bạn chắc là muốn cập nhật?", "Thông báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                try
                {

                    HoaDonBLL.InsertUpdate(txtMaHD.Text, cbxMaNV.Text,
                            cbxMaKH.Text,DateTime.Parse( dtmNgayLapHD.Text),DateTime.Parse( dtmNgayNhanHang.Text));
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
                    HoaDonBLL.Delete(txtMaHD.Text);
                    DataBind();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Có lỗi " + ex.Message);
                }
                catch
                {
                    MessageBox.Show("Không xóa được do có tham chiếu tới bảng khác");
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
