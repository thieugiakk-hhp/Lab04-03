using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_03.Models;

namespace Lab04_03
{
    public partial class frmFaculty : Form
    {
        #region Properties
        StudentContext context;

        List<Faculty> faculties;
        #endregion

        public frmFaculty()
        {
            InitializeComponent();

            context = new StudentContext();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            faculties = context.Faculties.ToList();

            btnXoa.Enabled = false;

            GetFacultyToDataGridView(faculties);
        }

        private void GetFacultyToDataGridView(List<Faculty> list)
        {
            dgvKhoaVien.Rows.Clear();

            foreach (var item in list)
            {
                int indexRow = dgvKhoaVien.Rows.Add();
                dgvKhoaVien.Rows[indexRow].Cells[0].Value = item.FacultyID.ToString();
                dgvKhoaVien.Rows[indexRow].Cells[1].Value = item.FacultyName.ToString();
                dgvKhoaVien.Rows[indexRow].Cells[2].Value = item.TotalProfessor.ToString(); ;
            }
        }

        private void dgvKhoaVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhoaVien.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                dgvKhoaVien.CurrentRow.Selected = true;
                txtMaKhoa.Text = dgvKhoaVien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenKhoa.Text = dgvKhoaVien.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtTongGS.Text = dgvKhoaVien.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ô bạn chọn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetValue()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtTongGS.Text = "";
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "" || txtTongGS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Faculty faculty = context.Faculties.FirstOrDefault(p => p.FacultyID.ToString() == txtMaKhoa.Text);

                if (faculty == null)
                {
                    faculty = new Faculty();
                    if (int.TryParse(txtMaKhoa.Text, out int id))
                    {
                        faculty.FacultyID = id;
                    }
                    else
                    {
                        MessageBox.Show("Mã khoa phải là dãy số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    faculty.FacultyName = txtTenKhoa.Text;
                    if (int.TryParse(txtTongGS.Text, out int total))
                    {
                        faculty.TotalProfessor = total;
                    }
                    else
                    {
                        MessageBox.Show("Tổng số Giáo sư phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.Faculties.Add(faculty);
                    context.SaveChanges();

                    faculties = context.Faculties.ToList();

                    GetFacultyToDataGridView(faculties);

                    MessageBox.Show("Thêm thông tin Khoa/Viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetValue();
                }
                else
                {
                    faculty = context.Faculties.FirstOrDefault(p => p.FacultyID.ToString() == txtMaKhoa.Text);

                    faculty.FacultyName = txtTenKhoa.Text;
                    if (int.TryParse(txtTongGS.Text, out int total))
                    {
                        faculty.TotalProfessor = total;
                    }
                    else
                    {
                        MessageBox.Show("Tổng số Giáo sư phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.SaveChanges();

                    faculties = context.Faculties.ToList();

                    GetFacultyToDataGridView(faculties);

                    MessageBox.Show("Cập nhật Khoa/Viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetValue();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Faculty faculty = context.Faculties.FirstOrDefault(p => p.FacultyID.ToString() == txtMaKhoa.Text);
            if (faculty != null)
            {
                if (MessageBox.Show("Bạn chắc chắn sẽ xóa Khoa/Viện này ra khỏi danh sách?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.Faculties.Remove(faculty);
                    context.SaveChanges();

                    faculties = context.Faculties.ToList();

                    GetFacultyToDataGridView(faculties);

                    MessageBox.Show("Xóa Khoa/Viện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy Khoa/Viện cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng trang?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
