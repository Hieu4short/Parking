using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongBaiGiuXe
{
    public partial class LuotGuiXe : Form
    {

        public LuotGuiXe()
        {
            InitializeComponent();
            hienthi();
            LoadLoaiXeComboBox();
            LoadIDTheGuiXeComboBox();

            dataGridView1.Columns["HinhAnhTrichXuat"].Visible = false;
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "Truy xuất ảnh";
            buttonColumn1.Text = "Mở hình ảnh";
            buttonColumn1.UseColumnTextForButtonValue = true; // Hiển thị text trên nút
            dataGridView1.Columns.Add(buttonColumn1);

            dataGridView2.Columns["HinhAnhTrichXuat"].Visible = false;
            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "Truy xuất ảnh";
            buttonColumn2.Text = "Mở hình ảnh";
            buttonColumn2.UseColumnTextForButtonValue = true; // Hiển thị text trên nút
            dataGridView2.Columns.Add(buttonColumn2);
        }



        private void LoadLoaiXeComboBox()
        {
            string query = "SELECT id, TenLoaiXe FROM LoaiXe";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Thiết lập ComboBox
                //comboBoxLoaiXe.DisplayMember = "TenLoaiXe"; // Hiển thị tên loại xe
                //comboBoxLoaiXe.ValueMember = "id"; // Giá trị thực sự được chọn là Id
                //comboBoxLoaiXe.DataSource = table; // Đặt nguồn dữ liệu cho ComboBox
            }
        }

        private void LoadIDTheGuiXeComboBox()
        {
            string query = "SELECT * FROM TheGuiXe WHERE TrangThaiThe = N'Trống'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Thiết lập ComboBox
                //comboBoxIDTheGuiXe.DisplayMember = "MaSoThe"; // Hiển thị trạng thái thẻ gửi xe
                //comboBoxIDTheGuiXe.ValueMember = "id";
                //comboBoxIDTheGuiXe.DataSource = table; // Đặt nguồn dữ liệu cho ComboBox
            }
        }



        /*private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllLuotGuiXe().Tables[0];
            //dataGridView1.DataMember = "LuotGuiXe";
        }*/

        private void hienthi()
        {


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllLuotGuiXe().Tables[0];
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = GetAllXuatBen().Tables[0];
        }
        //SqlConnectionString
        //Sqlcommand
        //SqlDataAdapter
        DataSet GetAllLuotGuiXe()
        {
            //SqlConnectionString
            DataSet data = new DataSet();
            string query = "SELECT LuotGuiXe.*, LoaiXe.TenLoaiXe FROM LuotGuiXe JOIN LoaiXe ON LuotGuiXe.IdLoaiXe = LoaiXe.id WHERE LuotGuiXe.TrangThai = N'Đã nhận xe' ORDER BY id DESC";
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
        DataSet GetAllXuatBen()
        {
            //SqlConnectionString
            DataSet data = new DataSet();
            string query = "SELECT LuotGuiXe.*, LoaiXe.TenLoaiXe FROM LuotGuiXe JOIN LoaiXe ON LuotGuiXe.IdLoaiXe = LoaiXe.id WHERE LuotGuiXe.TrangThai = N'Đã trả xe' ORDER BY id DESC";
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

        /*private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
        }*/

        private void selectRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                //txtMaNhanXe.Text = row.Cells["MaNhanXe"].Value.ToString();
                //txtDinhDanhXe.Text = row.Cells["DinhDanhXe"].Value.ToString();
                //txtIDTheGuiXe.Text = row.Cells["IDTheGuiXe"].Value.ToString();
                //txtThoiGianNhanXe.Text = row.Cells["ThoiGianNhanXe"].Value.ToString();
                //txtThoiGianTraXe.Text = row.Cells["ThoiGianTraXe"].Value.ToString();
                //txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
            else
            {
                Debug.WriteLine("No selected row");
            }
        }


        private void buttonChupAnh_Click(object sender, EventArgs e)
        {
            ChupAnh f = new ChupAnh();
            f.ShowDialog();
        }

        private void buttonNhapBen_Click(object sender, EventArgs e)
        {
            //string loaiXe = comboBoxLoaiXe.SelectedValue.ToString(); // Lấy giá trị của loại xe từ ComboBox
            //string dinhDanhXe = txtDinhDanhXe.Text.Trim(); // Lấy định danh xe từ TextBox
            //string idTheGuiXe = comboBoxIDTheGuiXe.SelectedValue.ToString(); // Lấy giá trị của ID thẻ gửi xe từ ComboBox
            //string trangThai = "Đã nhận xe"; // Lấy trạng thái từ TextBox
            //string thoiGianNhanXe = txtThoiGianNhanXe.Text.Trim(); // Lấy thời gian nhận xe từ TextBox
            //string thoiGianTraXe = txtThoiGianTraXe.Text.Trim(); // Lấy thời gian trả xe từ TextBox

            //Thực hiện cập nhật dữ liệu vào cơ sở dữ liệu
            //UpdateData(loaiXe, dinhDanhXe, idTheGuiXe, trangThai, thoiGianNhanXe, thoiGianTraXe);

            ChupAnh f = new ChupAnh();
            f.DialogClosed += Reload;
            f.ShowDialog();
        }

        private void Reload(object sender, Boolean updated)
        {
            hienthi();
        }

        /*private void UpdateData(string loaiXe, string dinhDanhXe, string idTheGuiXe, string trangThai, string thoiGianNhanXe, string thoiGianTraXe)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO LuotGuiXe (IdLoaiXe, DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, TrangThai) VALUES (@IdLoaiXe, @DinhDanhXe, @IdTheGuiXe, GETDATE(), @ThoiGianTraXe, @TrangThai)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@IdLoaiXe", loaiXe);
                        command.Parameters.AddWithValue("@DinhDanhXe", dinhDanhXe);
                        command.Parameters.AddWithValue("@IdTheGuiXe", idTheGuiXe);
                        command.Parameters.AddWithValue("@ThoiGianNhanXe", thoiGianNhanXe);
                        command.Parameters.AddWithValue("@ThoiGianTraXe", thoiGianTraXe);
                        command.Parameters.AddWithValue("@TrangThai", trangThai);

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("loaiXe: " + loaiXe + ". dinhDanhXe" + dinhDanhXe + ". idTheGuiXe: " + idTheGuiXe + ". thoiGianNhanXe: " + thoiGianNhanXe + ". thoiGianTraXe: " + thoiGianTraXe + ". trangThai: " + trangThai, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/


        private void buttonXuatBen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn từ dataGridView1
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ hàng được chọn
                string idLuotGuiXe = selectedRow.Cells["id"].Value.ToString();
                string tenLoaiXe = selectedRow.Cells["TenLoaiXe"].Value.ToString();
                string idLoaiXe = selectedRow.Cells["IdLoaiXe"].Value.ToString();
                string dinhDanhXe = selectedRow.Cells["DinhDanhXe"].Value.ToString();
                string idTheGuiXe = selectedRow.Cells["IdTheGuiXe"].Value.ToString();
                string thoiGianNhanXe = selectedRow.Cells["ThoiGianNhanXe"].Value.ToString();
                string thoiGianTraXe = selectedRow.Cells["ThoiGianTraXe"].Value.ToString();
                Image photo = ByteArrayToImage((byte[])selectedRow.Cells["HinhAnhTrichXuat"]?.Value);


                // Chuyển dữ liệu đến form XuatBen
                XuatBen f = new XuatBen();
                f.SetData(idLuotGuiXe, tenLoaiXe, idLoaiXe, dinhDanhXe, idTheGuiXe, thoiGianNhanXe, thoiGianTraXe, photo);
                f.DialogClosed += Reload;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong bảng để xác định dữ liệu cần xử lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            //{
            //    // Mở kết nối
            //    connection.Open();

            //    // Câu truy vấn để lấy dữ liệu từ hai bảng LuotGuiXe và DoanhThu
            //    string query = "SELECT LuotGuiXe.DinhDanhXe, TheGuiXe.MaSoThe, LuotGuiXe.ThoiGianNhanXe, LuotGuiXe.ThoiGianTraXe, LoaiXe.TenLoaiXe, LoaiXe.DonGiaGuiXe " +
            //                       "FROM LuotGuiXe " +
            //                       "INNER JOIN TheGuiXe ON LuotGuiXe.IdTheGuiXe = TheGuiXe.id " +
            //                       "INNER JOIN LoaiXe ON LuotGuiXe.IdLoaiXe = LoaiXe.id " +
            //                       "WHERE LuotGuiXe.TrangThai = N'Đã trả xe'";

            //    // Tạo đối tượng SqlCommand để thực thi câu truy vấn
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        // Sử dụng SqlDataAdapter để lấy dữ liệu và đổ vào DataSet
            //        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //        {
            //            DataSet dataset = new DataSet();
            //            adapter.Fill(dataset);

            //            // Tính lợi nhuận cho từng dòng dữ liệu
            //            foreach (DataRow row in dataset.Tables[0].Rows)
            //            {
            //                string loaiXe = row["TenLoaiXe"].ToString();
            //                decimal donGia = Convert.ToDecimal(row["DonGiaGuiXe"]);

            //                // Khởi tạo biến lợi nhuận với giá trị mặc định
            //                decimal loiNhuan = 0;

            //                // Kiểm tra loại xe và gán giá trị lợi nhuận tương ứng
            //                if (loaiXe == "Xe Đạp")
            //                {
            //                    loiNhuan = 1000; // Giá trị lợi nhuận cho xe đạp
            //                }
            //                else if (loaiXe == "Xe Máy")
            //                {
            //                    loiNhuan = 3000; // Giá trị lợi nhuận cho xe máy
            //                }
            //                else
            //                {
            //                    // Xử lý trường hợp khác nếu cần
            //                }

            //                if (!dataset.Tables[0].Columns.Contains("Lợi nhuận"))
            //                {
            //                    dataset.Tables[0].Columns.Add("Lợi nhuận", typeof(decimal)); // Thêm cột với kiểu dữ liệu là decimal
            //                }

            //                // Thêm cột lợi nhuận vào DataSet
            //                row["Lợi nhuận"] = loiNhuan;


            //                // Cập nhật dữ liệu lợi nhuận vào cơ sở dữ liệu
            //                UpdateLoiNhuanToDatabase(row); // Hàm này cần phải được xác định và triển khai để cập nhật dữ liệu vào cơ sở dữ liệu
            //            }
            //            // Gọi phương thức LoadDataToDataGridView từ form LoiNhuan và truyền DataSet vào
            //            LoiNhuan loiNhuanForm = new LoiNhuan();
            //            loiNhuanForm.LoadDataToDataGridView(dataset.Tables[0]);
            //        }
            //    }
            //}
        }
        public void UpdateLoiNhuanToDatabase(DataRow row)
        {
            try
            {
                // Lấy các thông tin từ DataRow
                string dinhDanhXe = row["DinhDanhXe"].ToString();
                string maSoThe = row["MaSoThe"].ToString();
                DateTime thoiGianNhanXe = Convert.ToDateTime(row["ThoiGianNhanXe"]);
                DateTime thoiGianTraXe = Convert.ToDateTime(row["ThoiGianTraXe"]);
                string loaiXe = row["TenLoaiXe"].ToString();
                decimal donGiaGuiXe = Convert.ToDecimal(row["DonGiaGuiXe"]);

                // Tính toán doanh thu
                decimal doanhThu = 0;
                TimeSpan thoiGianGui = thoiGianTraXe - thoiGianNhanXe;
                if (loaiXe == "Xe Máy" || loaiXe == "Xe Đạp")
                {
                    doanhThu = donGiaGuiXe * (decimal)thoiGianGui.TotalHours;
                }

                // Kết nối đến cơ sở dữ liệu và cập nhật vào bảng DoanhThu
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    string sqlQuery = "INSERT INTO DoanhThu (NgayThucHien, DoanhThu, IdLuotGuiXe) " +
                                      "VALUES (@NgayThucHien, @DoanhThu, " +
                                      "(SELECT id FROM LuotGuiXe WHERE DinhDanhXe = @DinhDanhXe AND IdTheGuiXe = " +
                                      "(SELECT id FROM TheGuiXe WHERE MaSoThe = @MaSoThe)))";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@NgayThucHien", DateTime.Now);
                        cmd.Parameters.AddWithValue("@DoanhThu", doanhThu);
                        cmd.Parameters.AddWithValue("@DinhDanhXe", dinhDanhXe);
                        cmd.Parameters.AddWithValue("@MaSoThe", maSoThe);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật doanh thu vào cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex] ?? null;

                if (row != null)
                {
                    string dinhDanhXe;
                    if (row.Cells["DinhDanhXe"] != null)
                    {
                        dinhDanhXe = row.Cells["DinhDanhXe"].Value.ToString();
                    }
                    else
                    {
                        dinhDanhXe = ""; // Or handle missing value differently
                    }

                    string loaiXe = row.Cells["TenLoaiXe"]?.Value?.ToString() ?? ""; // Null-conditional chaining for optional chaining
                    string idTheGuiXe = row.Cells["IdTheGuiXe"]?.Value?.ToString() ?? "";
                    string trangThai = row.Cells["TrangThai"]?.Value?.ToString() ?? "";
                    string thoiGianTraXe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        if (row.Cells["HinhAnhTrichXuat"]?.Value is System.DBNull)
                        {
                            MessageBox.Show("Không có hình ảnh để hiển thị");
                        }
                        else
                        {
                            // Mở form mới khi nút được click
                            Image photo = ByteArrayToImage((byte[])row.Cells["HinhAnhTrichXuat"]?.Value);
                            TruyXuatHinhAnh f = new TruyXuatHinhAnh(photo);
                            f.ShowDialog();
                        }
                    }

                    //AddOrUpdateRowToDataGridView2(loaiXe, dinhDanhXe, idTheGuiXe, trangThai, thoiGianTraXe, data);
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                try
                {
                    return Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Lỗi khi chuyển đổi mảng byte thành hình ảnh: " + ex.Message);
                    return null;
                }
            }
        }



        /*private void AddOrUpdateRowToDataGridView2(string loaiXe, string dinhDanhXe, string idTheGuiXe, string trangThai, string thoiGianTraXe, DataSet data)
        {
            // Kiểm tra xem DataSet đã có bảng nào chưa
            if (data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                // Kiểm tra xem dòng có tồn tại trong dataGridView2 không
                bool rowExists = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["DinhDanhXe"]?.Value?.ToString() == dinhDanhXe)
                    {
                        rowExists = true;
                        // Cập nhật thông tin nếu dòng đã tồn tại
                        row.Cells["loaiXe"].Value = loaiXe;
                        row.Cells["DinhDanhXe"].Value = dinhDanhXe;
                        row.Cells["IdTheGuiXe"].Value = idTheGuiXe;
                        row.Cells["TrangThai"].Value = trangThai;
                        row.Cells["ThoiGianTraXe"].Value = thoiGianTraXe;
                        break;
                    }
                }

                // Nếu dòng không tồn tại, thêm dòng mới vào DataTable trong DataSet và cập nhật lại DataGridView
                if (!rowExists)
                {
                    DataRow newRow = data.Tables[0].NewRow();
                    newRow["loaiXe"] = loaiXe;
                    newRow["DinhDanhXe"] = dinhDanhXe;
                    newRow["IdTheGuiXe"] = idTheGuiXe;
                    newRow["TrangThai"] = trangThai;
                    newRow["ThoiGianTraXe"] = thoiGianTraXe;
                    data.Tables[0].Rows.Add(newRow);

                    // Cập nhật lại DataGridView từ DataSet
                    dataGridView2.DataSource = data.Tables[0];
                }
            }
            else
            {
                // Nếu DataSet chưa có bảng, bạn cần tạo một DataTable mới và thêm nó vào DataSet trước khi thêm dòng mới
                DataTable newTable = new DataTable();
                newTable.Columns.Add("loaiXe", typeof(string));
                newTable.Columns.Add("DinhDanhXe", typeof(string));
                newTable.Columns.Add("IdTheGuiXe", typeof(string));
                newTable.Columns.Add("TrangThai", typeof(string));
                newTable.Columns.Add("ThoiGianTraXe", typeof(string));

                DataRow newRow = newTable.NewRow();
                newRow["loaiXe"] = loaiXe;
                newRow["DinhDanhXe"] = dinhDanhXe;
                newRow["IdTheGuiXe"] = idTheGuiXe;
                newRow["TrangThai"] = trangThai;
                newRow["ThoiGianTraXe"] = thoiGianTraXe;
                newTable.Rows.Add(newRow);

                // Thêm DataTable vào DataSet và cập nhật lại DataGridView
                data.Tables.Add(newTable);
                dataGridView2.DataSource = newTable;
            }
        }*/



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                var row = dataGridView2.Rows[e.RowIndex] ?? null;

                if (row != null)
                {

                    if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        if (row.Cells["HinhAnhTrichXuat"]?.Value is System.DBNull)
                        {
                            MessageBox.Show("Không có hình ảnh để hiển thị");
                        }
                        else
                        {
                            // Mở form mới khi nút được click
                            Image photo = ByteArrayToImage((byte[])row.Cells["HinhAnhTrichXuat"]?.Value);
                            TruyXuatHinhAnh f = new TruyXuatHinhAnh(photo);
                            f.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
