using System;
using AForge;
using AForge.Video.DirectShow;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using System.IO;
using System.Data.SqlClient;

namespace HeThongBaiGiuXe
{
    public partial class ChupAnh : Form
    {
        private static string folderPath = @"D:\\Niên luận\\nlcs\\Parking\\HinhAnh";
        private FilterInfoCollection videoDevicesLists;
        private IVideoSource videoSource;

        public delegate void DialogClosedEventHandler(object sender, Boolean updated);
        public event DialogClosedEventHandler DialogClosed;

        public ChupAnh()
        {
            InitializeComponent();
            LoadLoaiXeComboBox();
            LoadIDTheGuiXeComboBox();

            videoDevicesLists = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesLists)
            {
                comboBoxVideoSource.Items.Add(videoDevice.Name);
            }
            if (comboBoxVideoSource.Items.Count > 0)
            {
                comboBoxVideoSource.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không tìm thấy video sources", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Closing += Form1_Closing;
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
                cbLoaiXe.DisplayMember = "TenLoaiXe"; // Hiển thị tên loại xe
                cbLoaiXe.ValueMember = "id"; // Giá trị thực sự được chọn là Id
                cbLoaiXe.DataSource = table; // Đặt nguồn dữ liệu cho ComboBox
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
                cbIDTheGuiXe.DisplayMember = "MaSoThe"; // Hiển thị trạng thái thẻ gửi xe
                cbIDTheGuiXe.ValueMember = "id";
                cbIDTheGuiXe.DataSource = table; // Đặt nguồn dữ liệu cho ComboBox
            }
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void buttonChupBienSo_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevicesLists[comboBoxVideoSource.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }

        private void buttonDongY_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            //if (videoSource != null && videoSource.IsRunning && pictureBox1.Image != null)
            //{
            //    pictureBox1.Image.Dispose();
            //}
            //if (pictureBox1.Image != null)
            //{
            //    // Tạo tên tệp tin duy nhất dựa trên thời gian
            //    string fileName = "Image_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
            //    byte[] pathBytes = System.Text.Encoding.Unicode.GetBytes(folderPath);
            //    string encodedFolderPath = System.Text.Encoding.Unicode.GetString(pathBytes);
            //    string filePath = Path.Combine(encodedFolderPath, fileName);

            //    // Lưu hình ảnh vào tệp tin
            //    pictureBox1.Image.Save(filePath);

            //    // Cập nhật cơ sở dữ liệu với đường dẫn của tệp tin hình ảnh
            //    UpdateDatabase(filePath);

            //    // Dừng video source và giải phóng hình ảnh
            //    videoSource.SignalToStop();
            //    videoSource.WaitForStop();
            //    pictureBox1.Image.Dispose();
            //}
            //else
            //{
            //    MessageBox.Show("Không có hình ảnh để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        private void UpdateDatabase(string filePath)
        {
            try
            {
                // Mã SQL để cập nhật đường dẫn tệp tin vào cơ sở dữ liệu
                string connectionString = @"Data Source=DESKTOP-NNRDGLA\SQLEXPRESS;Initial Catalog=BaiGiuXe;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO LuotGuiXe (DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, TrangThai, HinhAnhTrichXuat) VALUES (@DinhDanhXe, @IdTheGuiXe, @ThoiGianNhanXe, @ThoiGianTraXe, @TrangThai, @HinhAnhTrichXuat)";
                    //string query = "SELECT * FROM LuotGuiXe;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DinhDanhXe", txtDinhDanhXe.Text);
                        command.Parameters.AddWithValue("@IdTheGuiXe", cbIDTheGuiXe.Text);
                        command.Parameters.AddWithValue("@ThoiGianNhanXe", DateTime.Now);
                        command.Parameters.AddWithValue("@ThoiGianTraXe", DateTime.Now);
                        command.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text);
                        command.Parameters.AddWithValue("@HinhAnhTrichXuat", File.ReadAllBytes(filePath));
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLuuHinhAnh_Click(object sender, EventArgs e)
        {
            /*if (pictureBox1.Image != null)
            {
                // Hiển thị hộp thoại lưu tệp
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                // Lưu hình ảnh vào tệp tin nếu người dùng đã chọn vị trí lưu
                if (saveFileDialog1.FileName != "")
                {
                    // Lưu hình ảnh từ pictureBox
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                    MessageBox.Show("Hình ảnh đã được lưu thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không có hình ảnh để lưu!");
            }*/

            string loaiXe = cbLoaiXe.SelectedValue.ToString(); // Lấy giá trị của loại xe từ ComboBox
            string dinhDanhXe = txtDinhDanhXe.Text.Trim(); // Lấy định danh xe từ TextBox
            string idTheGuiXe = cbIDTheGuiXe.SelectedValue.ToString(); // Lấy giá trị của ID thẻ gửi xe từ ComboBox
            string trangThai = "Đã nhận xe"; // Lấy trạng thái từ TextBox
            string thoiGianNhanXe = txtThoiGianNhanXe.Text.Trim(); // Lấy thời gian nhận xe từ TextBox
            string thoiGianTraXe = txtThoiGianTraXe.Text.Trim(); // Lấy thời gian trả xe từ TextBox

            // Thực hiện cập nhật dữ liệu vào cơ sở dữ liệu
            UpdateData(loaiXe, dinhDanhXe, idTheGuiXe, trangThai, thoiGianNhanXe, thoiGianTraXe, ImageToByteArray(pictureBox1.Image));
            MessageBox.Show("Nhận xe thành công.");
            Close();
            DialogClosed?.Invoke(this, true);

            //    if (pictureBox1.Image != null)
            //    {
            //        // Tạo tên tệp tin duy nhất dựa trên thời gian
            //        string fileName = "Image_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
            //        byte[] pathBytes = System.Text.Encoding.Unicode.GetBytes(folderPath);
            //        string encodedFolderPath = System.Text.Encoding.Unicode.GetString(pathBytes);
            //        string filePath = Path.Combine(encodedFolderPath, fileName);

            //        // Lưu hình ảnh vào tệp tin
            //        pictureBox1.Image.Save(filePath);
            //        UpdateDatabase(filePath);
            //        pictureBox1.Image.Dispose();

            //        MessageBox.Show("Hình ảnh đã được lưu thành công vào " + folderPath);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không có hình ảnh để lưu!");
            //    }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }


        private void UpdateData(string loaiXe, string dinhDanhXe, string idTheGuiXe, string trangThai, string thoiGianNhanXe, string thoiGianTraXe, byte[] Photo)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO LuotGuiXe (IdLoaiXe, DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, TrangThai, HinhAnhTrichXuat) VALUES (@IdLoaiXe, @DinhDanhXe, @IdTheGuiXe, GETDATE(), @ThoiGianTraXe, @TrangThai, @HinhAnhTrichXuat)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đặt các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@IdLoaiXe", loaiXe);
                        command.Parameters.AddWithValue("@DinhDanhXe", dinhDanhXe);
                        command.Parameters.AddWithValue("@IdTheGuiXe", idTheGuiXe);
                        command.Parameters.AddWithValue("@ThoiGianNhanXe", thoiGianNhanXe);
                        command.Parameters.AddWithValue("@ThoiGianTraXe", thoiGianTraXe);
                        command.Parameters.AddWithValue("@TrangThai", trangThai);
                        command.Parameters.AddWithValue("@HinhAnhTrichXuat", Photo);

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
        }

        private void labelThoiGianNhanXe_Click(object sender, EventArgs e)
        {

        }
    }
}
