
namespace Pharmacy
{
    partial class FormQuanLyDoanhThu
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
        private void InitializeComponent()
        {
            this.pnlForm = new System.Windows.Forms.Panel();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.btnXemToanBo = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.timeEnd);
            this.pnlForm.Controls.Add(this.timeStart);
            this.pnlForm.Controls.Add(this.btnXemToanBo);
            this.pnlForm.Controls.Add(this.btnLoc);
            this.pnlForm.Controls.Add(this.txtTong);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label10);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(903, 196);
            this.pnlForm.TabIndex = 3;
            // 
            // timeEnd
            // 
            this.timeEnd.Location = new System.Drawing.Point(355, 67);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(405, 27);
            this.timeEnd.TabIndex = 7;
            // 
            // timeStart
            // 
            this.timeStart.Location = new System.Drawing.Point(355, 38);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(405, 27);
            this.timeStart.TabIndex = 7;
            // 
            // btnXemToanBo
            // 
            this.btnXemToanBo.BackColor = System.Drawing.Color.Teal;
            this.btnXemToanBo.FlatAppearance.BorderSize = 0;
            this.btnXemToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemToanBo.ForeColor = System.Drawing.Color.White;
            this.btnXemToanBo.Location = new System.Drawing.Point(610, 133);
            this.btnXemToanBo.Name = "btnXemToanBo";
            this.btnXemToanBo.Size = new System.Drawing.Size(150, 50);
            this.btnXemToanBo.TabIndex = 5;
            this.btnXemToanBo.Text = "Tổng";
            this.btnXemToanBo.UseVisualStyleBackColor = false;
            this.btnXemToanBo.Click += new System.EventHandler(this.btnXemToanBo_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Teal;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(355, 133);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(150, 50);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(355, 100);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(405, 27);
            this.txtTong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(142, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(142, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "Từ ngày";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(142, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tổng tiền";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvw
            // 
            this.lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw.FullRowSelect = true;
            this.lvw.HideSelection = false;
            this.lvw.Location = new System.Drawing.Point(0, 196);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(903, 351);
            this.lvw.TabIndex = 4;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày lập";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khách mua";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng tiền";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // FormQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lvw);
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormQuanLyDoanhThu";
            this.Size = new System.Drawing.Size(903, 547);
            this.Load += new System.EventHandler(this.FormQuanLyDoanhThu_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnXemToanBo;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.Label label2;

    }
}
