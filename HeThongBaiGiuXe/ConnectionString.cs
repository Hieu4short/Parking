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
    public partial class ConnectionString : Form
    {
        public static string connectionString = @"Data Source=DESKTOP-CLCRRT4;Initial Catalog=BaiGiuXe;Integrated Security=True;TrustServerCertificate=True";

        public ConnectionString()
        {
            InitializeComponent();
        }

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
