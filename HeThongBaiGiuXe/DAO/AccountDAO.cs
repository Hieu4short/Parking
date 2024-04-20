using HeThongBaiGiuXe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongBaiGiuXe
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO()
        {

        }

        public bool Login(string Username, string Password)
        {
            string query = "SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = N'" + Username + "' AND MatKhau = N'" + Password + "';";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
