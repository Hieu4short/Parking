using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace HeThongBaiGiuXe
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
            hienthi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllDoanhThu().Tables[0];
            //dataGridView1.DataMember = "DoanhThu";
        }

        private void hienthi()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllDoanhThu().Tables[0];
        }

        //connection String
        DataSet GetAllDoanhThu()
        {
            DataSet data = new DataSet();

            //SQLConnection
            //sau khi xài xong là bỏ
            string query = "select * from DoanhThu";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            //SQLCommand
            //SQLDataAdapter

            return data;
        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {
            selectRow();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                selectRow();
            }
        }

        private void selectRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtNgayThucHien.Text = row.Cells["NgayThucHien"].Value.ToString();
                txtDoanhThu.Text = row.Cells["DoanhThu"].Value.ToString();
                txtIDLuotGui.Text = row.Cells["IDLuotGuiXe"].Value.ToString();
            }
            else
            {
                Debug.WriteLine("No selected row");
            }
        }


        Modify modify = new Modify();

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "HeThongBaiGiuXe.Report2.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSetDoanhThu";
            reportDataSource.Value = modify.Table("SELECT * FROM DoanhThu");
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }



        /*private void DoanhThu_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "HeThongBaiGiuXe.Report2.rdlc";

            // Khởi tạo kết nối và câu truy vấn SQL
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                //string query = @"SELECT DoanhThu.NgayThucHien, DoanhThu.DoanhThu, LuotGuiXe.IdLoaiXe, LuotGuiXe.DinhDanhXe, LuotGuiXe.IdTheGuiXe, LuotGuiXe.ThoiGianNhanXe, LuotGuiXe.ThoiGianTraXe, LuotGuiXe.HinhAnhTrichXuat, LuotGuiXe.TrangThai
                //         FROM DoanhThu 
                //         INNER JOIN LuotGuiXe ON DoanhThu.IdLuotGuiXe = LuotGuiXe.id";
                string query = @"SELECT DoanhThu.NgayThucHien AS NgayThucHienDT, DoanhThu.DoanhThu AS DoanhThuDT, NULL AS IdLoaiXe, NULL AS DinhDanhXe, NULL AS IdTheGuiXe, NULL AS ThoiGianNhanXe, NULL AS ThoiGianTraXe, NULL AS HinhAnhTrichXuat, NULL AS TrangThai
                             FROM DoanhThu
                             UNION ALL
                             SELECT NgayThucHien, DoanhThu, IdLoaiXe, DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, HinhAnhTrichXuat, TrangThai
                             FROM LuotGuiXe";
                //string query = "SELECT DoanhThu.NgayThucHien, DoanhThu.DoanhThu, LuotGuiXe.id AS IDLuotGuiXe " +
                //               "FROM DoanhThu " + "INNER JOIN LuotGuiXe ON DoanhThu.IdLuotGuiXe = LuotGuiXe.id";
                //string query = @"SELECT
                //                LG.IdLoaiXe, LG.DinhDanhXe, LG.IdTheGuiXe, LG.ThoiGianNhanXe, LG.ThoiGianTraXe, DT.NgayThucHien, DT.DoanhThu
                //                FROM DoanhThu DT INNER JOIN LuotGuiXe LG ON DT.IdLuotGuiXe = LG.id";

                // Thực thi câu truy vấn và đặt dữ liệu vào ReportViewer
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Đặt nguồn dữ liệu cho ReportViewer
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DataSetDoanhThu";
                    reportDataSource.Value = dataTable;
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                }
            }*/

            //this.reportViewer1.RefreshReport();
    }
}
