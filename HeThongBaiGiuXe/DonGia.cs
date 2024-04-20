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

namespace HeThongBaiGiuXe
{
    public partial class DonGia : Form
    {
        public DonGia()
        {
            InitializeComponent();
            hienthi();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllLoaiXe().Tables[0];
            //dataGridView1.DataMember = "LoaiXe";
        }

        private void hienthi()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllLoaiXe().Tables[0];
        }

        //connection String
        DataSet GetAllLoaiXe()
        {
            DataSet data = new DataSet();

            //SQLConnection
            //sau khi xài xong là bỏ
            string query = "select * from LoaiXe";
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

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string sql = @"UPDATE LoaiXe SET DonGiaGuiXe = '" + txtDonGia.Text + "' WHERE (MaLoaiXe = '" + txtMaLoaiXe.Text + "')";
                SqlCommand thuchien = new SqlCommand(sql, connection);
                thuchien.ExecuteNonQuery();
                connection.Close();
                hienthi();
            }
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

        private void selectRow() {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtMaLoaiXe.Text = row.Cells["MaLoaiXe"].Value.ToString();
                txtTenLoaiXe.Text = row.Cells["TenLoaiXe"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGiaGuiXe"].Value.ToString();
            }
            else
            {
                Debug.WriteLine("No selected row");
            }
        }
    }
}
