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
using WinFormCuoiKy.Model;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using WinFormCuoiKy.BLL;

namespace WinFormCuoiKy
{
    public partial class ThongTinNhanVien : Form
    {
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        public void DataBind()
        {
            try
            {
                dgvNhanVien.AutoGenerateColumns = false;
                dgvNhanVien.DataSource = NhanVienBLL.GetAll();
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                txtMaNhanVien.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
                dtmNgaySinh.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
                txtGioiTinh.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
                txtEmail.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
                dtmNgayVaoLam.Text = dgvNhanVien.Rows[r].Cells[8].Value.ToString();
                this.pbxNhanVien.Image = (System.Drawing.Image)
                                 dgvNhanVien.Rows[r].Cells[9].FormattedValue;
            }
            catch
            {
                MessageBox.Show("Có lỗi với các thuộc tính. Không thể ánh xạ");
            }
        }

        private void pbxNhanVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbxNhanVien.Image = Image.FromFile(open.FileName);
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

        private void btnLayHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbxNhanVien.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            byte[] HinhAnh = ImageToByteArray(pbxNhanVien.Image);
            DialogResult thongbao = MessageBox.Show("Bạn chắc là muốn cập nhật?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                try
                {
                    if (txtLuong.Text == "") txtLuong.Text = "1500";
                    NhanVienBLL.InsertUpdate(txtMaNhanVien.Text, txtTenNhanVien.Text
                            , DateTime.Parse(dtmNgaySinh.Text), txtGioiTinh.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text,
                           int.Parse(txtLuong.Text), DateTime.Parse(dtmNgayVaoLam.Text), HinhAnh);
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
                    NhanVienBLL.Delete(txtMaNhanVien.Text);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVienBLL.TimKiem(txtTimKiem.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {

                    ExportToExcel(dgvNhanVien, saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi: " + ex.Message);
                }
        }

        private void ExportToExcel(DataGridView g, string duongDan)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan);
            obj.ActiveWorkbook.Saved = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    
}
