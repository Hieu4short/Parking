using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongBaiGiuXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Username = txbUsername.Text;
            string Password = txbPassword.Text; 
            if (Login(Username, Password))
            {
                HeThongQuanLi f = new HeThongQuanLi();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show  ("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool Login (string Username, string Password) 
        {
            //return true;
            return AccountDAO.Instance.Login(Username, Password);
        }

        private void buttonLogout_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất hệ thống?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) { 
                e.Cancel = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
