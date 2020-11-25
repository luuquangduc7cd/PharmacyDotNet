
namespace Pharmacy
{
    partial class FormQuanLyBanHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lvwDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThuoc = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTim = new System.Windows.Forms.Button();
            this.pnlForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.lvwDanhSach);
            this.pnlForm.Controls.Add(this.panel1);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(903, 333);
            this.pnlForm.TabIndex = 3;
            // 
            // lvwDanhSach
            // 
            this.lvwDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvwDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDanhSach.FullRowSelect = true;
            this.lvwDanhSach.HideSelection = false;
            this.lvwDanhSach.Location = new System.Drawing.Point(638, 38);
            this.lvwDanhSach.Name = "lvwDanhSach";
            this.lvwDanhSach.Size = new System.Drawing.Size(265, 295);
            this.lvwDanhSach.TabIndex = 2;
            this.lvwDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSach.View = System.Windows.Forms.View.Details;
            this.lvwDanhSach.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSach_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên thuốc";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thành tiền";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnXuatHoaDon);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtThuoc);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 295);
            this.panel1.TabIndex = 1;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.Teal;
            this.btnXuatHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(475, 228);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(150, 50);
            this.btnXuatHoaDon.TabIndex = 18;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(244, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 50);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(13, 228);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 50);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(223, 177);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(405, 27);
            this.txtTongTien.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(223, 145);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(405, 27);
            this.txtSoLuong.TabIndex = 13;
            // 
            // txtThuoc
            // 
            this.txtThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtThuoc.Location = new System.Drawing.Point(223, 113);
            this.txtThuoc.Name = "txtThuoc";
            this.txtThuoc.Size = new System.Drawing.Size(405, 27);
            this.txtThuoc.TabIndex = 14;
            this.txtThuoc.TextChanged += new System.EventHandler(this.txtThuoc_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(223, 81);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(405, 27);
            this.txtDiaChi.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tổng tiền";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSdt
            // 
            this.txtSdt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSdt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSdt.Location = new System.Drawing.Point(223, 15);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(242, 27);
            this.txtSdt.TabIndex = 16;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(223, 48);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(405, 27);
            this.txtTen.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số lượng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tìm thuốc";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(10, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(188, 29);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Tên khách hàng";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvw
            // 
            this.lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw.FullRowSelect = true;
            this.lvw.HideSelection = false;
            this.lvw.Location = new System.Drawing.Point(0, 333);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(903, 214);
            this.lvw.TabIndex = 4;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.Details;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên thuốc";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn vị";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nhà sản xuất";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hạn sử dụng";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(475, 15);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(153, 29);
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // FormQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lvw);
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormQuanLyBanHang";
            this.Size = new System.Drawing.Size(903, 547);
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            this.pnlForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThuoc;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListView lvwDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnTim;
    }
}
