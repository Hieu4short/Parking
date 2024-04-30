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

namespace HeThongBaiGiuXe
{
    public partial class XuatBen : Form
    {

        public delegate void DialogClosedEventHandler(object sender, Boolean updated);
        public event DialogClosedEventHandler DialogClosed;

        public XuatBen()
        {
            InitializeComponent();
        }

        public void SetData(string idLuotGuiXe, string tenLoaiXe, string IdLoaiXe, string dinhDanhXe, string IdTheGuiXe, string ThoiGianNhanXe, string ThoiGianTraXe, Image photo)
        {
            /*string txtInputTenLoaiXe = tenLoaiXe;
            string txtInputIdLoaiXe = IdLoaiXe;
            string txtInputdinhDanhXe = dinhDanhXe;
            string txtInputIdTheGuiXe = IdTheGuiXe;
            string txtInputTrangThai = TrangThai;
            string txtInputThoiGianNhanXe = ThoiGianNhanXe;
            string txtInputThoiGianTraXe = null;*/
            textBoxID.Text = idLuotGuiXe;
            textBoxLoaiXe.Text = tenLoaiXe;
            //textBoxIDLoaiXe.Text = IdLoaiXe;
            textBoxDinhDanhXe.Text = dinhDanhXe;
            textBoxIDTheGuiXe.Text = IdTheGuiXe;
            textBoxThoiGianNhanXe.Text = ThoiGianNhanXe;
            textBoxThoiGianTraXe.Text = DateTime.Now.ToString();
            pictureBox1.Image = photo;
        }

        private void textBoxLoaiXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDinhDanhXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDTheGuiXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxThoiGianNhanXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxThoiGianTraXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTraXe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn tiếp tục cho xe xuất bến không?", "Xác nhận trả xe", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int id = int.Parse(textBoxID.Text);
                string thoiGianTraXe = textBoxThoiGianTraXe.Text;
                CapNhatXuatBen(id, thoiGianTraXe);
                MessageBox.Show("Xe đã được trả ra");
                this.Close();
                DialogClosed?.Invoke(this, true);
            }
        }

        private void CapNhatXuatBen(int id, String thoiGianTraXe)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    string query = "UPDATE LuotGuiXe SET TrangThai = N'Đã trả xe', ThoiGianTraXe = @ThoiGianTraXe WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@ThoiGianTraXe", thoiGianTraXe);
                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                    }
                    decimal dongia = 0;
                    string queryDonGia = "SELECT DonGiaGuiXe From LoaiXe WHERE id = (SELECT IdLoaiXe FROM LuotGuiXe as LGX WHERE LGX.id = @idLuotGuiXe)";
                    using (SqlCommand command = new SqlCommand(queryDonGia, connection)) {
                        command.Parameters.AddWithValue("@idLuotGuiXe", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dongia = reader.GetDecimal(0);
                            }
                        }
                    }

                    string queryDoanhThu = "INSERT INTO DoanhThu (NgayThucHien, DoanhThu, IdLuotGuiXe) VALUES (@NgayThucHien, @DoanhThu, @IdLuotGuiXe)"; 
                    using (SqlCommand command = new SqlCommand(queryDoanhThu, connection))
                    {
                        command.Parameters.AddWithValue("@NgayThucHien", thoiGianTraXe);
                        command.Parameters.AddWithValue("@DoanhThu", dongia);
                        command.Parameters.AddWithValue("@IdLuotGuiXe", id);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}