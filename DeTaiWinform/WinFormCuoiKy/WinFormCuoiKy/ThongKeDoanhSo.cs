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
    public partial class ThongKeDoanhSo : Form
    {
        public ThongKeDoanhSo()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhSo_Load(object sender, EventArgs e)
        {
            DoanhSoNhanVien();
            //DoanhSoTheoThang();
        }

        public void DoanhSoNhanVien()
        {
            QLBXModel context = new QLBXModel();
            var kq = from ct in context.ChiTietHoaDons
                     from hd in context.HoaDons
                     where ct.MaHD == hd.MaHD
                     group hd by hd.MaNV into g
                     select new { g.Key, sl = g.Count() };


            DataTable table = new DataTable();
            table.Columns.Add("MaNV", typeof(string));
            table.Columns.Add("SoHD", typeof(int));
            foreach (var i in kq)
            {
                table.Rows.Add(i.Key, i.sl);
            }
            chart1.DataSource = table;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã NV";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số hóa đơn";
            chart1.Series["Series1"].XValueMember = "MaNV";
            chart1.Series["Series1"].YValueMembers = "SoHD";
        }
    }
}
