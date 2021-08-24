
namespace Lab04_03
{
    partial class frmFaculty
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbThongTinKhoa = new System.Windows.Forms.GroupBox();
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhoaVien = new System.Windows.Forms.DataGridView();
            this.dgvMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grbThongTinKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinKhoa
            // 
            this.grbThongTinKhoa.Controls.Add(this.txtTongGS);
            this.grbThongTinKhoa.Controls.Add(this.txtTenKhoa);
            this.grbThongTinKhoa.Controls.Add(this.txtMaKhoa);
            this.grbThongTinKhoa.Controls.Add(this.label3);
            this.grbThongTinKhoa.Controls.Add(this.label2);
            this.grbThongTinKhoa.Controls.Add(this.label1);
            this.grbThongTinKhoa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grbThongTinKhoa.Location = new System.Drawing.Point(10, 11);
            this.grbThongTinKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.grbThongTinKhoa.Name = "grbThongTinKhoa";
            this.grbThongTinKhoa.Padding = new System.Windows.Forms.Padding(2);
            this.grbThongTinKhoa.Size = new System.Drawing.Size(260, 190);
            this.grbThongTinKhoa.TabIndex = 11;
            this.grbThongTinKhoa.TabStop = false;
            this.grbThongTinKhoa.Text = "Thông tin khoa";
            // 
            // txtTongGS
            // 
            this.txtTongGS.Location = new System.Drawing.Point(106, 100);
            this.txtTongGS.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(150, 20);
            this.txtTongGS.TabIndex = 6;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(106, 65);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(150, 20);
            this.txtTenKhoa.TabIndex = 5;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(106, 30);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(150, 20);
            this.txtMaKhoa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng số GS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khoa";
            // 
            // dgvKhoaVien
            // 
            this.dgvKhoaVien.AllowUserToAddRows = false;
            this.dgvKhoaVien.AllowUserToDeleteRows = false;
            this.dgvKhoaVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoaVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKhoa,
            this.dgvTenKhoa,
            this.dgvTongGS});
            this.dgvKhoaVien.Location = new System.Drawing.Point(274, 11);
            this.dgvKhoaVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhoaVien.Name = "dgvKhoaVien";
            this.dgvKhoaVien.ReadOnly = true;
            this.dgvKhoaVien.RowHeadersWidth = 51;
            this.dgvKhoaVien.RowTemplate.Height = 24;
            this.dgvKhoaVien.Size = new System.Drawing.Size(400, 224);
            this.dgvKhoaVien.TabIndex = 14;
            this.dgvKhoaVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoaVien_CellClick);
            // 
            // dgvMaKhoa
            // 
            this.dgvMaKhoa.HeaderText = "Mã Khoa";
            this.dgvMaKhoa.MinimumWidth = 6;
            this.dgvMaKhoa.Name = "dgvMaKhoa";
            this.dgvMaKhoa.Width = 115;
            // 
            // dgvTenKhoa
            // 
            this.dgvTenKhoa.HeaderText = "Tên Khoa";
            this.dgvTenKhoa.MinimumWidth = 6;
            this.dgvTenKhoa.Name = "dgvTenKhoa";
            this.dgvTenKhoa.Width = 140;
            // 
            // dgvTongGS
            // 
            this.dgvTongGS.HeaderText = "Tổng Số GS";
            this.dgvTongGS.MinimumWidth = 6;
            this.dgvTongGS.Name = "dgvTongGS";
            this.dgvTongGS.Width = 90;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(103, 205);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(10, 205);
            this.btnThemSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(75, 30);
            this.btnThemSua.TabIndex = 12;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(195, 205);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 246);
            this.Controls.Add(this.grbThongTinKhoa);
            this.Controls.Add(this.dgvKhoaVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.btnDong);
            this.Name = "frmFaculty";
            this.Text = "Khoa/Viện";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            this.grbThongTinKhoa.ResumeLayout(false);
            this.grbThongTinKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinKhoa;
        private System.Windows.Forms.TextBox txtTongGS;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhoaVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTongGS;
    }
}