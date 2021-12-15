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
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            try
            {
                dgvKhachHang.AutoGenerateColumns = false;
                dgvKhachHang.DataSource = KhachHangBLL.GetAll();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Có lỗi " + e.Message);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table . Lỗi rồi!!!");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            txtThanhPho.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            txtSoDienThoai.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            DialogResult thongbao = MessageBox.Show("Bạn chắc là muốn cập nhật?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                try
                {
                    //if (txtLuong.Text == "") txtLuong.Text = "1500";
                    KhachHangBLL.InsertUpdate(txtMaKH.Text, txtTenKH.Text,
                            txtDiaChi.Text, txtThanhPho.Text, txtSoDienThoai.Text);
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
                    KhachHangBLL.Delete(txtMaKH.Text);
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
            dgvKhachHang.DataSource = KhachHangBLL.TimKiem(txtTimKiem.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {

                    ExportToExcel(dgvKhachHang, saveFileDialog.FileName);
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
