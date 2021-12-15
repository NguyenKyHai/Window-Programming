using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCuoiKy.BLL;
using WinFormCuoiKy.Model;

namespace WinFormCuoiKy
{
    public partial class ThongTinSanPham : Form
    {
        public ThongTinSanPham()
        {
            InitializeComponent();
        }

        private void ThongTinSanPham_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            try
            {
                dgvSanPham.AutoGenerateColumns = false;
                dgvSanPham.DataSource = SanPhamBLL.GetAll();
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

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSanPham.CurrentCell.RowIndex;
            txtMaXe.Text = dgvSanPham.Rows[r].Cells[0].Value.ToString();
            txtTenXe.Text = dgvSanPham.Rows[r].Cells[1].Value.ToString();
            txtHangXe.Text = dgvSanPham.Rows[r].Cells[2].Value.ToString();
            dtmNamSanXuat.Text = dgvSanPham.Rows[r].Cells[3].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[r].Cells[4].Value.ToString();
            this.pbxSanPham.Image = (System.Drawing.Image)
                             dgvSanPham.Rows[r].Cells[5].FormattedValue;
        }

        private void pbxSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbxSanPham.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            try
            {
                img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch
            {
                MessageBox.Show("Lỗi hình ảnh");
            }
            return m.ToArray();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            byte[] HinhAnh = ImageToByteArray(pbxSanPham.Image);
            DialogResult thongbao = MessageBox.Show("Bạn chắc là muốn cập nhật?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                try
                {
                    if (txtDonGia.Text == "") txtDonGia.Text = "15000";
                    SanPhamBLL.InsertUpdate(txtMaXe.Text, txtTenXe.Text,
                       txtHangXe.Text, DateTime.Parse(dtmNamSanXuat.Text), long.Parse(txtDonGia.Text), HinhAnh);
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
                    SanPhamBLL.Delete(txtMaXe.Text);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPhamBLL.TimKiem(txtTimKiem.Text);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
