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
    public partial class ThongKeLuong : Form
    {
        public ThongKeLuong()
        {
            InitializeComponent();
        }

        private void ThongKeLuong_Load(object sender, EventArgs e)
        {
            QLBXModel context = new QLBXModel();
            var kq = from p in context.NhanViens
                     group p by p.Luong into g
                     select new { g.Key, sl = g.Count() };
            DataTable table = new DataTable();
            table.Columns.Add("Luong", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            foreach (var i in kq)
            {
                table.Rows.Add(i.Key, i.sl);
            }
            chart1.DataSource = table;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Lương";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
            chart1.Series["Series1"].XValueMember = "Luong";
            chart1.Series["Series1"].YValueMembers = "SoLuong";
        }
    }
}
