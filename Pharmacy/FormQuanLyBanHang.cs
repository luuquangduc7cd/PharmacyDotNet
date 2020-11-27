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
    public partial class FormQuanLyBanHang : UserControl
    {
        private NhanVien nhanVien;
        private List<DTOThuoc> listThuoc;
        private List<DTOKhach> listKhach;
        private double tien = 0;
        public FormQuanLyBanHang(DTONhanVien nv)
        {
            InitializeComponent();
            nhanVien = new NhanVien(nv);
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            Init();
            AutoCompleteStringCollection colKhach = new AutoCompleteStringCollection();
            foreach (DTOKhach i in listKhach)
                colKhach.Add(i.Sdt);
            txtSdt.AutoCompleteCustomSource = colKhach;
            AutoCompleteStringCollection colThuoc = new AutoCompleteStringCollection();
            foreach (DTOThuoc i in listThuoc)
                colThuoc.Add(i.Ten);
            txtThuoc.AutoCompleteCustomSource = colThuoc;
        }

        private void Init()
        {
            listThuoc = nhanVien.TimKiemThuoc(null);
            listKhach = nhanVien.TimKhach(null);
            LoadThuocToListView(listThuoc);
        }
        private void LoadThuocToListView(List<DTOThuoc> list)
        {
            lvw.Items.Clear();
            foreach (DTOThuoc i in list)
            {
                string[] row = { i.Ten, i.DonVi, i.DonGia.ToString("#,###.##"), i.SoLuong.ToString(), i.NhaCungCap, i.HanSuDung };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Name = i.Id.ToString();
                lvi.Tag = i;
                lvw.Items.Add(lvi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtSoLuong.Text, @"\d"))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            if (lvw.SelectedItems.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn thuốc theo danh sách dưới đây");
                return;                
            }
            DTOThuoc thuoc = (DTOThuoc)lvw.SelectedItems[0].Tag;
            int soLuong = int.Parse(txtSoLuong.Text);
            if (soLuong > thuoc.SoLuong)
            {
                MessageBox.Show("Số lượng vượt quá khả năng cung cấp của nhà thuốc");
                return;
            }
            thuoc.SoLuong = soLuong;
            LoadThuocToHoaDon(thuoc, soLuong);
        }

        private void LoadThuocToHoaDon(DTOThuoc thuoc, int soLuong)
        {
            tien += thuoc.DonGia * soLuong;
            txtTongTien.Text = tien.ToString("#,###.##");
            string[] row = { thuoc.Ten, thuoc.SoLuong.ToString(), (soLuong * thuoc.DonGia).ToString() };
            ListViewItem lvi = new ListViewItem(row);
            lvi.Tag = thuoc;
            lvwDanhSach.Items.Add(lvi);
        }

        private void lvwDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwDanhSach.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
                for (int i = 1; i < lvwDanhSach.SelectedItems.Count; i++)
                    lvwDanhSach.SelectedItems[i].Selected = false;
            }
            else
                btnXoa.Enabled = false;
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if(lvwDanhSach.Items.Count < 1)
            {
                MessageBox.Show("Khách hàng cần mua ít nhất một sản phẩm để có thể lập hóa đơn");
                return;
            }
            if (!ValidKhachHang())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }
            else
            {
                DTOKhach khach = new DTOKhach();
                khach.DiaChi = txtDiaChi.Text;
                khach.Sdt = txtSdt.Text;
                khach.Ten = txtTen.Text;

                DTOHoaDon hoaDon = new DTOHoaDon();
                hoaDon.IdNhanVien = nhanVien.DataNhanVien.Id;
                hoaDon.NgayLap = DateTime.Now.ToString("dd/MM/yyyy");

                List<DTOChiTietHoaDon> dtoCthd = new List<DTOChiTietHoaDon>();
                int tong = 0;
                foreach(ListViewItem i in lvwDanhSach.Items)
                {
                    DTOThuoc temp = (DTOThuoc)i.Tag;
                    DTOChiTietHoaDon cthd = new DTOChiTietHoaDon();
                    cthd.SoLuong = temp.SoLuong;
                    cthd.IdThuoc = temp.Id;
                    dtoCthd.Add(cthd);
                    tong += int.Parse(i.SubItems[2].Text);
                }
                hoaDon.TongTien = tien.ToString("#,###.##");
                if (nhanVien.NhapHoaDon(khach, hoaDon, dtoCthd))
                {
                    ClearForm();
                    MessageBox.Show("Nhập hóa đơn thành công!\nKhách hàng " + khach.Ten);
                }
                else
                    MessageBox.Show("Có lỗi");
            }
        }

        private void ClearForm()
        {
            tien = 0;
            txtSoLuong.Clear();
            txtTongTien.Clear();
            txtSdt.Clear();
            txtTen.Clear();
            txtThuoc.Clear();
            txtDiaChi.Clear();
            lvwDanhSach.Items.Clear();
        }

        private bool ValidKhachHang()
        {
            return !string.IsNullOrEmpty(txtTen.Text) &&
                    !string.IsNullOrEmpty(txtDiaChi.Text) &&
                    !string.IsNullOrEmpty(txtSdt.Text);
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvw.SelectedItems.Count > 0)
            {
                DTOThuoc thuoc = (DTOThuoc) lvw.SelectedItems[0].Tag;
                LoadThuocToForm(thuoc);
                for (int i = 1; i < lvw.SelectedItems.Count; i++)
                    lvw.SelectedItems[i].Selected = false;
            }
        }

        private void LoadThuocToForm(DTOThuoc thuoc)
        {
            txtThuoc.Text = thuoc.Ten;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwDanhSach.SelectedItems.Count > 0)
            {
                DTOThuoc thuoc = (DTOThuoc)lvw.SelectedItems[0].Tag;
                tien -= thuoc.DonGia * int.Parse(lvwDanhSach.SelectedItems[0].SubItems[2].Text);
                lvwDanhSach.Items.Remove(lvwDanhSach.SelectedItems[0]);
                txtTongTien.Text = tien.ToString();
            }
        }

        private void txtThuoc_TextChanged(object sender, EventArgs e)
        {
            string strSearch = txtThuoc.Text.Trim();
            foreach(ListViewItem i in lvw.Items)
                if (i.SubItems[0].Text.Contains(strSearch))
                {
                    i.Selected = true;
                    DTOThuoc temp = (DTOThuoc)i.Tag;
                    return;
                }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            tien = 0;
            DTOKhach khack = nhanVien.TimTheoSdt(txtSdt.Text);
            if (khack != null)
            {
                lblId.Tag = khack.Id;
                txtTen.Text = khack.Ten;
                txtSdt.Text = khack.Sdt;
                txtDiaChi.Text = khack.DiaChi;
            }
        }
    }
}
