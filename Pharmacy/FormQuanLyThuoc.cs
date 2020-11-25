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
using BLL;
using DTO;

namespace Pharmacy
{
    public partial class FormQuanLyThuoc : UserControl
    {
        private DTONhanVien dtoNhanVien;
        private NhanVien nhanVien;
        public FormQuanLyThuoc()
        {
            InitializeComponent();
        }
        public FormQuanLyThuoc(DTONhanVien nv)
        {
            InitializeComponent();
            dtoNhanVien = nv;
            nhanVien = new NhanVien(nv);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenThuoc.Clear();
            txtDonVi.Clear();
            txtGia.Clear();
            txtNhaCungCap.Clear();
            txtSoLuong.Clear();
            time.Value = DateTime.Now;
        }

        private void FormThemThuoc_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            List<DTOThuoc> danhSach = nhanVien.TimKiemThuoc(null);
            LoadThuocToListView(danhSach);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvw.SelectedItems.Count > 0)
            {
                DTOThuoc thuoc = (DTOThuoc)lvw.SelectedItems[0].Tag;
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa " + thuoc.Ten + " khỏi danh sách?",
                                                    "Xóa thuốc", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    if (nhanVien.XoaThuoc(thuoc))
                    {
                        MessageBox.Show("Xóa thành công");
                        Reload();
                    }
                }
            }
        }

        private void Reload()
        {
            Init();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidThuoc())
            {
                DTOThuoc thuoc = new DTOThuoc();
                thuoc.Ten = txtTenThuoc.Text;
                thuoc.DonVi = txtDonVi.Text;
                thuoc.DonGia = (int)double.Parse(txtGia.Text);
                thuoc.SoLuong = int.Parse(txtSoLuong.Text);
                thuoc.NhaCungCap = txtNhaCungCap.Text;
                thuoc.HanSuDung = time.Value.ToString("dd/MM/yyyy");
                thuoc.IdNhanVien = dtoNhanVien.Id;
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn thêm " + thuoc.Ten + " vào cơ sở dữ liệu?", "Thêm thuốc", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (nhanVien.ThemThuoc(thuoc))
                    {
                        MessageBox.Show("Thêm thành công: " + thuoc.Ten);
                        Reload();
                    }
                    else
                        MessageBox.Show("Thêm không thành công: " + thuoc.Ten);
                }
            }
            else
                MessageBox.Show("Dữ liệu không hợp lệ");
        }

        private bool ValidThuoc()
        {
            return !string.IsNullOrEmpty(txtTenThuoc.Text) &&
                    !string.IsNullOrEmpty(txtDonVi.Text) &&
                    !LaSo(txtGia.Text) &&
                    !string.IsNullOrEmpty(txtNhaCungCap.Text) &&
                    !LaSo(txtSoLuong.Text);
        }

        private bool LaSo(string text)
        {
            char[] temp = text.Trim().ToCharArray();
            if (text.Length < 1)
                return false;
            for (int i = 0; i < temp.Length; i++)
                if (!char.IsDigit(temp[i]) || !(temp[i] == '.') || !(temp[i] == ','))
                    return false;
            return true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<DTOThuoc> list = nhanVien.TimKiemThuoc(txtTenThuoc.Text.Trim());
            LoadThuocToListView(list);
        }

        private void LoadThuocToListView(List<DTOThuoc> list)
        {
            lvw.Items.Clear();
            foreach(DTOThuoc i in list)
            {
                string[] row = { i.Ten, i.DonVi, i.DonGia.ToString("#,###.##"), i.SoLuong.ToString(), i.NhaCungCap, i.HanSuDung };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Name = i.Id.ToString();
                lvi.Tag = i;
                lvw.Items.Add(lvi);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ValidThuoc())
            {
                DTOThuoc thuoc = new DTOThuoc();
                thuoc.Id = (int)lblId.Tag;
                thuoc.Ten = txtTenThuoc.Text;
                thuoc.DonVi = txtDonVi.Text;
                thuoc.DonGia = (int)double.Parse(txtGia.Text);
                thuoc.SoLuong = int.Parse(txtSoLuong.Text);
                thuoc.NhaCungCap = txtNhaCungCap.Text;
                thuoc.HanSuDung = time.Value.ToString("dd/MM/yyyy");
                thuoc.IdNhanVien = dtoNhanVien.Id;
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn cập nhât " + thuoc.Ten + " vào cơ sở dữ liệu?", "Thêm thuốc", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (nhanVien.CapNhatThuoc(thuoc))
                    {
                        MessageBox.Show("Cập nhật thành công: " + thuoc.Ten);
                        Reload();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công: " + thuoc.Ten);
                }
            }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvw.SelectedItems.Count > 0)
            {
                DTOThuoc thuoc = (DTOThuoc)lvw.SelectedItems[0].Tag;
                lblId.Tag = thuoc.Id;
                LoadThuocToForm(thuoc);
                lvw.SelectedItems[0].Selected = true;
                for (int i = 1; i < lvw.SelectedItems.Count; i++)
                    lvw.SelectedItems[i].Selected = false;
            }
        }

        private void LoadThuocToForm(DTOThuoc thuoc)
        {
            txtTenThuoc.Text = thuoc.Ten;
            txtDonVi.Text = thuoc.DonVi;
            txtGia.Text = thuoc.DonGia.ToString("#,###.##");
            txtNhaCungCap.Text = thuoc.NhaCungCap;
            txtSoLuong.Text = thuoc.SoLuong.ToString("#,###.##");
            time.Value = DateTime.ParseExact(thuoc.HanSuDung, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
