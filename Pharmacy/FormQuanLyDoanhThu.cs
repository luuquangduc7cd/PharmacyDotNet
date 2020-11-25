using BLL;
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
    public partial class FormQuanLyDoanhThu : UserControl
    {
        private NhanVien nhanVien;
        public FormQuanLyDoanhThu(DTONhanVien nv)
        {
            nhanVien = new NhanVien(nv);
            InitializeComponent();
        }

        private void FormQuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            List<DTOHoaDonKhach> list = nhanVien.ThongKe(null, null);
            LoadListHoaDonToListView(list);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if(ValidTime())
            {
                List<DTOHoaDonKhach> list = nhanVien.ThongKe(null, null);
                LoadListHoaDonToListView(list);
                return;
            }
            MessageBox.Show("Thời gian không hợp lệ");
        }

        private void LoadListHoaDonToListView(List<DTOHoaDonKhach> list)
        {
            lvw.Items.Clear();
            double tong = 0;
            foreach(DTOHoaDonKhach i in list)
            {
                string[] row = { i.Id.ToString(), i.NgayLap, i.Khach, i.Tong };
                ListViewItem lvi = new ListViewItem(row);
                tong += double.Parse(i.Tong);
                lvw.Items.Add(lvi);
            }
            txtTong.Text = tong.ToString("#,###.##");
        }

        private bool ValidTime()
        {
            if (DateTime.Compare(timeStart.Value, timeEnd.Value) <= 0)
                return true;
            return false;
        }

        private void btnXemToanBo_Click(object sender, EventArgs e)
        {
            List<DTOHoaDonKhach> list = nhanVien.ThongKe(null, null);
            LoadListHoaDonToListView(list);
        }
    }
}
