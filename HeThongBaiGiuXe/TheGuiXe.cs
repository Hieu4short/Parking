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
    public partial class TheGuiXe : Form
    {
        public TheGuiXe()
        {
            InitializeComponent();
            hienthi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllTheGuiXe().Tables[0];
            //dataGridView1.DataMember = "TheGuiXe";
        }
        private void hienthi()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllTheGuiXe().Tables[0];
        }
        //SqlConnectionString
        //Sqlcommand
        //SqlDataAdapter
        DataSet GetAllTheGuiXe()
        {
            //SqlConnectionString
            DataSet data = new DataSet();
            string query = "SELECT * FROM TheGuiXe;";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) 
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            //Sqlcommand
            //SqlDataAdapter
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
                //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //txtMaSoThe.Text = row.Cells["MaSoThe"].Value.ToString();
                //txtTrangThaiThe.Text = row.Cells["TrangThaiThe"].Value.ToString();
                //txtTinhTrangThe.Text = row.Cells["txtTinhTrangThe"].Value.ToString();
            }
        }

        private void selectRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtMaSoThe.Text = row.Cells["MaSoThe"].Value.ToString();
                txtTrangThaiThe.Text = row.Cells["TrangThaiThe"].Value.ToString();
                txtTinhTrangThe.Text = row.Cells["TinhTrangThe"].Value.ToString();
            }
            else
            {
                Debug.WriteLine("No selected row");
            }
        }

        private void buttonThemThe_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES (@MaSoThe, @TrangThaiThe, @TinhTrangThe)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaSoThe", txtMaSoThe.Text);
                command.Parameters.AddWithValue("@TrangThaiThe", txtTrangThaiThe.Text);
                command.Parameters.AddWithValue("@TinhTrangThe", txtTinhTrangThe.Text);

                command.ExecuteNonQuery();
                connection.Close();
                hienthi();
            }
        }

        private void buttonXoaThe_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                //string sql = @"DELETE FROM TheGuiXe (MaSoThe, TrangThaiThe, TinhTrangThe) VALUES (@MaSoThe, @TrangThaiThe, @TinhTrangThe)";
                string sql = @"DELETE FROM TheGuiXe WHERE MaSoThe = @MaSoThe";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaSoThe", txtMaSoThe.Text);
                //command.Parameters.AddWithValue("@TrangThaiThe", txtTrangThaiThe.Text);
                //command.Parameters.AddWithValue("@TinhTrangThe", txtTinhTrangThe.Text);

                command.ExecuteNonQuery();
                connection.Close();
                hienthi();
            }
        }
    }
}
