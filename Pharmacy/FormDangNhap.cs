using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmLogin : Form
    {
        private string user = "^1[0-9]{6}1";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            if (Regex.IsMatch(txtUser.Text, user) && txtPassword.Text.Length > 8)
            {
                NhanVien nv = new NhanVien(txtUser.Text, txtPassword.Text);
                if (nv.DangNhap())
                {
                    DTONhanVien temp = nv.DataNhanVien;
                    FormQuanLy frmMain = new FormQuanLy(temp);
                    this.Hide();
                    frmMain.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
            }
            else
                MessageBox.Show("Dữ liệu không hợp lệ");
        }
    }
}
