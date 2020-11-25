using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormQuanLy : Form
    {
        private DTONhanVien nhanVien;
        private FormQuanLyThuoc frmQuanLyThuoc;
        private FormQuanLyBanHang frmQuanLyBanHang;
        private FormQuanLyKhachHang frmQuanLyKhachHang;
        private FormQuanLyDoanhThu frmQuanLyDoanhThu;
        public FormQuanLy(DTONhanVien nv)
        {
            InitializeComponent();
            nhanVien = nv;
        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            pnlSubForm.Controls.Clear();
            if(frmQuanLyThuoc == null)
                frmQuanLyThuoc = new FormQuanLyThuoc(nhanVien);
            pnlSubForm.Controls.Add(frmQuanLyThuoc);
            frmQuanLyThuoc.Dock = DockStyle.Fill;
        }

        private void HideAllMenu()
        {
            pnlQuanLyBanHang.Height = pnlQuanLyBanHang.MinimumSize.Height;
        }

        

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            HideAllMenu();
            pnlQuanLyBanHang.Height = pnlQuanLyBanHang.MaximumSize.Height;
            this.Text = "Quản lý danh mục";
        }

        private void btnLietKe_Click(object sender, EventArgs e)
        {
            pnlSubForm.Controls.Clear();
            FormQuanLyThuoc frmThemThuoc = new FormQuanLyThuoc();
            pnlSubForm.Controls.Add(frmThemThuoc);
            frmThemThuoc.Dock = DockStyle.Fill;
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn thoát khỏi chương trình?", "Thoát", MessageBoxButtons.YesNo);
            e.Cancel = (dr == DialogResult.No);
        }

        private void btnNhapHoaDon_Click(object sender, EventArgs e)
        {
            pnlSubForm.Controls.Clear();
            if (frmQuanLyBanHang == null)
                frmQuanLyBanHang = new FormQuanLyBanHang(nhanVien);
            pnlSubForm.Controls.Add(frmQuanLyBanHang);
            frmQuanLyBanHang.Dock = DockStyle.Fill;
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            if (frmQuanLyKhachHang == null)
                frmQuanLyKhachHang = new FormQuanLyKhachHang(nhanVien);
            pnlSubForm.Controls.Clear();
            pnlSubForm.Controls.Add(frmQuanLyKhachHang);
            frmQuanLyKhachHang.Dock = DockStyle.Fill;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (frmQuanLyDoanhThu == null)
                frmQuanLyDoanhThu = new FormQuanLyDoanhThu(nhanVien);
            pnlSubForm.Controls.Clear();
            pnlSubForm.Controls.Add(frmQuanLyDoanhThu);
            frmQuanLyDoanhThu.Dock = DockStyle.Fill;
        }
    }
}
