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
        private static string folderPath = "E:\\NLCS\\HeThongBaiXe\\HinhAnh";
        private FilterInfoCollection videoDevicesLists;
        private IVideoSource videoSource;

        public ChupAnh()
        {
            InitializeComponent();

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
        public TextBox txtDinhDanhXe;
        public TextBox txtIdTheGuiXe;
        public TextBox txtTrangThai;


        private void Form1_Closing (object sender, CancelEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
        }

        private void video_NewFrame (object sender, NewFrameEventArgs eventArgs)
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
            if (videoSource != null && videoSource.IsRunning && pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            if (pictureBox1.Image != null)
            {
                // Tạo tên tệp tin duy nhất dựa trên thời gian
                string fileName = "Image_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                string filePath = Path.Combine(folderPath, fileName);

                // Lưu hình ảnh vào tệp tin
                pictureBox1.Image.Save(filePath);

                // Cập nhật cơ sở dữ liệu với đường dẫn của tệp tin hình ảnh
                UpdateDatabase(filePath);

                // Dừng video source và giải phóng hình ảnh
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image.Dispose();
            }
            else
            {
                MessageBox.Show("Không có hình ảnh để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateDatabase(string filePath)
        {
            try
            {
                // Mã SQL để cập nhật đường dẫn tệp tin vào cơ sở dữ liệu
                string connectionString = @"Data Source=DESKTOP-CLCRRT4;Initial Catalog=BaiGiuXe;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO LuotGuiXe (DinhDanhXe, IdTheGuiXe, ThoiGianNhanXe, ThoiGianTraXe, TrangThai, HinhAnhTrichXuat) VALUES (@DinhDanhXe, @IdTheGuiXe, @ThoiGianNhanXe, @ThoiGianTraXe, @TrangThai, @HinhAnhTrichXuat)";
                    //string query = "SELECT * FROM LuotGuiXe;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DinhDanhXe", txtDinhDanhXe.Text);
                        command.Parameters.AddWithValue("@IdTheGuiXe", txtIdTheGuiXe.Text);
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
            if (pictureBox1.Image != null)
            {
                // Tạo tên tệp tin duy nhất dựa trên thời gian
                string fileName = "Image_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                string filePath = Path.Combine(folderPath, fileName);

                // Lưu hình ảnh vào tệp tin
                pictureBox1.Image.Save(filePath);

                MessageBox.Show("Hình ảnh đã được lưu thành công vào " + folderPath);
            }
            else
            {
                MessageBox.Show("Không có hình ảnh để lưu!");
            }
        }
    }
}
