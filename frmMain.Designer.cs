
namespace Lab04_03
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsbtnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnQuanLyKhoa = new System.Windows.Forms.ToolStripButton();
            this.mtsThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsQuanLyKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cbbKhoaVien = new System.Windows.Forms.ComboBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoaVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAvgScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbtnTimKiem
            // 
            this.tsbtnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTimKiem.Image")));
            this.tsbtnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTimKiem.Name = "tsbtnTimKiem";
            this.tsbtnTimKiem.Size = new System.Drawing.Size(76, 22);
            this.tsbtnTimKiem.Text = "Tìm kiếm";
            this.tsbtnTimKiem.Click += new System.EventHandler(this.tsbtnTimKiem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnQuanLyKhoa,
            this.tsbtnTimKiem});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(834, 25);
            this.toolStrip.TabIndex = 22;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbtnQuanLyKhoa
            // 
            this.tsbtnQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnQuanLyKhoa.Image")));
            this.tsbtnQuanLyKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuanLyKhoa.Name = "tsbtnQuanLyKhoa";
            this.tsbtnQuanLyKhoa.Size = new System.Drawing.Size(97, 22);
            this.tsbtnQuanLyKhoa.Text = "Quản lý khoa";
            this.tsbtnQuanLyKhoa.Click += new System.EventHandler(this.tsbtnQuanLyKhoa_Click);
            // 
            // mtsThoat
            // 
            this.mtsThoat.Image = ((System.Drawing.Image)(resources.GetObject("mtsThoat.Image")));
            this.mtsThoat.Name = "mtsThoat";
            this.mtsThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mtsThoat.Size = new System.Drawing.Size(184, 26);
            this.mtsThoat.Text = "Thoát";
            this.mtsThoat.Click += new System.EventHandler(this.mtsThoat_Click);
            // 
            // mtsTimKiem
            // 
            this.mtsTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("mtsTimKiem.Image")));
            this.mtsTimKiem.Name = "mtsTimKiem";
            this.mtsTimKiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mtsTimKiem.Size = new System.Drawing.Size(184, 26);
            this.mtsTimKiem.Text = "Tìm kiếm";
            this.mtsTimKiem.Click += new System.EventHandler(this.mtsTimKiem_Click);
            // 
            // mtsQuanLyKhoa
            // 
            this.mtsQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("mtsQuanLyKhoa.Image")));
            this.mtsQuanLyKhoa.Name = "mtsQuanLyKhoa";
            this.mtsQuanLyKhoa.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mtsQuanLyKhoa.Size = new System.Drawing.Size(184, 26);
            this.mtsQuanLyKhoa.Text = "Quản lý khoa";
            this.mtsQuanLyKhoa.Click += new System.EventHandler(this.mtsQuanLyKhoa_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsQuanLyKhoa,
            this.mtsTimKiem,
            this.mtsThoat});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMSSV,
            this.dgvHoTen,
            this.dgvKhoaVien,
            this.dgvAvgScore});
            this.dgvStudents.Location = new System.Drawing.Point(288, 68);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(535, 212);
            this.dgvStudents.TabIndex = 20;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(109, 250);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 250);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm trung bình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khoa/Viện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(834, 24);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cbbKhoaVien
            // 
            this.cbbKhoaVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoaVien.FormattingEnabled = true;
            this.cbbKhoaVien.Location = new System.Drawing.Point(96, 95);
            this.cbbKhoaVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbbKhoaVien.Name = "cbbKhoaVien";
            this.cbbKhoaVien.Size = new System.Drawing.Size(175, 21);
            this.cbbKhoaVien.TabIndex = 8;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(96, 130);
            this.txtDTB.Margin = new System.Windows.Forms.Padding(2);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(175, 20);
            this.txtDTB.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(96, 61);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(175, 20);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(96, 27);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(175, 20);
            this.txtMSSV.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(209, 250);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbKhoaVien);
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(9, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(275, 178);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số SV:";
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.FillWeight = 304.5685F;
            this.dgvMSSV.HeaderText = "Mã số sinh viên";
            this.dgvMSSV.MinimumWidth = 6;
            this.dgvMSSV.Name = "dgvMSSV";
            this.dgvMSSV.ReadOnly = true;
            this.dgvMSSV.Width = 112;
            // 
            // dgvHoTen
            // 
            this.dgvHoTen.FillWeight = 52.91531F;
            this.dgvHoTen.HeaderText = "Họ Tên";
            this.dgvHoTen.MinimumWidth = 6;
            this.dgvHoTen.Name = "dgvHoTen";
            this.dgvHoTen.ReadOnly = true;
            this.dgvHoTen.Width = 170;
            // 
            // dgvKhoaVien
            // 
            this.dgvKhoaVien.FillWeight = 27.25241F;
            this.dgvKhoaVien.HeaderText = "Khoa/Viện";
            this.dgvKhoaVien.MinimumWidth = 6;
            this.dgvKhoaVien.Name = "dgvKhoaVien";
            this.dgvKhoaVien.ReadOnly = true;
            this.dgvKhoaVien.Width = 150;
            // 
            // dgvAvgScore
            // 
            this.dgvAvgScore.FillWeight = 15.26382F;
            this.dgvAvgScore.HeaderText = "DTB";
            this.dgvAvgScore.MinimumWidth = 6;
            this.dgvAvgScore.Name = "dgvAvgScore";
            this.dgvAvgScore.ReadOnly = true;
            this.dgvAvgScore.Width = 50;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 286);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtnTimKiem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbtnQuanLyKhoa;
        private System.Windows.Forms.ToolStripMenuItem mtsThoat;
        private System.Windows.Forms.ToolStripMenuItem mtsTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mtsQuanLyKhoa;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ComboBox cbbKhoaVien;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKhoaVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAvgScore;
    }
}

