using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Pharmacy
{
    public partial class FormQuanLyKhachHang : UserControl
    {
        private NhanVien nhanVien;
        public FormQuanLyKhachHang(DTONhanVien nv)
        {
            InitializeComponent();
            nhanVien = new NhanVien(nv);
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            List<DTOKhach> list = nhanVien.TimKhach(null);
            LoadListKhachToListView(list);
        }

        private void LoadListKhachToListView(List<DTOKhach> list)
        {
            lvw.Items.Clear();
            foreach(DTOKhach item in list)
            {
                string[] row = { item.Id.ToString(), item.Ten, item.Sdt, item.DiaChi };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Tag = item;
                lvw.Items.Add(lvi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidKhach())
            {
                DTOKhach temp = new DTOKhach();
                temp.Ten = txtTen.Text;
                temp.DiaChi = txtDiaChi.Text;
                temp.Sdt = txtSdt.Text;
                DialogResult dr = MessageBox.Show("Xác nhận thêm khách hàng " + temp.Ten, "Thêm khách hàng", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    if(nhanVien.ThemKhach(temp))
                    {
                        MessageBox.Show("Thêm thành công khách hàng " + temp.Ten);
                        Reload();
                    }    
                    else
                        MessageBox.Show("Thêm không thành công khách hàng " + temp.Ten);
                }
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private bool ValidKhach()
        {
            return !string.IsNullOrEmpty(txtTen.Text) &&
                    !string.IsNullOrEmpty(txtSdt.Text) &&
                    !string.IsNullOrEmpty(txtDiaChi.Text);
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvw.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
                DTOKhach khach = (DTOKhach)lvw.SelectedItems[0].Tag;
                lvw.SelectedItems[0].Selected = true;
                LoadKhachToForm(khach);
            }
            else
                btnXoa.Enabled = false;
        }

        private void LoadKhachToForm(DTOKhach khach)
        {
            txtDiaChi.Text = khach.DiaChi;
            txtSdt.Text = khach.Sdt;
            txtTen.Text = khach.Ten;
            lblId.Tag = khach.Id;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvw.SelectedItems.Count < 1)
                MessageBox.Show("Vui lòng chọn một khách hàng trong danh sách dưới đây");
            else
            {
                DTOKhach khach = (DTOKhach)lvw.SelectedItems[0].Tag;
                DialogResult dr = MessageBox.Show("Xác nhận xóa khách hàng " + khach.Ten, "Xóa khách hàng", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    if (nhanVien.XoaKhach(khach.Id)) 
                    {
                        MessageBox.Show("Đã xóa khách hàng " + khach.Ten);
                        Reload();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công khách hàng " + khach.Ten);
                    }
                }
            }
        }

        private void Reload()
        {
            Init();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ValidKhach())
            {
                DTOKhach temp = new DTOKhach();
                temp.Id = (int)lblId.Tag;
                temp.Ten = txtTen.Text;
                temp.DiaChi = txtDiaChi.Text;
                temp.Sdt = txtSdt.Text;
                DialogResult dr = MessageBox.Show("Xác nhận cập nhật thông tin khách hàng " + temp.Ten, "Cập nhật", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (nhanVien.CapNhatKhach(temp))
                    {
                        MessageBox.Show("Cập nhật thành công khách hàng " + temp.Ten);
                        Reload();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công khách hàng " + temp.Ten);
                }
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<DTOKhach> list = nhanVien.TimKhach(txtTen.Text);
            LoadListKhachToListView(list);
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
