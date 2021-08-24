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
    public partial class frmMain : Form
    {
        #region Properties
        StudentContext context;

        List<Student> students;
        List<Faculty> faculties;
        #endregion

        public frmMain()
        {
            InitializeComponent();

            context = new StudentContext();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            students = context.Students.ToList();
            faculties = context.Faculties.ToList();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            GetFacultyToCombobox(faculties);
            GetStudentToDataGridView(students);
        }

        #region Lấy dữ liệu từ Database đổ lên Form
        private void GetFacultyToCombobox(List<Faculty> list)
        {
            cbbKhoaVien.DataSource = list;
            cbbKhoaVien.DisplayMember = "FacultyName";
            cbbKhoaVien.ValueMember = "FacultyID";
        }

        private void GetStudentToDataGridView(List<Student> list)
        {
            dgvStudents.Rows.Clear();

            foreach (var item in list)
            {
                int indexRow = dgvStudents.Rows.Add();
                dgvStudents.Rows[indexRow].Cells[0].Value = item.StudentID;
                dgvStudents.Rows[indexRow].Cells[1].Value = item.FullName;
                dgvStudents.Rows[indexRow].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudents.Rows[indexRow].Cells[3].Value = item.AverageScore;
            }
        }
        #endregion

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                dgvStudents.CurrentRow.Selected = true;

                txtMSSV.Text = dgvStudents.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtHoTen.Text = dgvStudents.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cbbKhoaVien.SelectedIndex = cbbKhoaVien.FindString(dgvStudents.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                txtDTB.Text = dgvStudents.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ô bạn chọn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetValue()
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            cbbKhoaVien.SelectedIndex = 0;
            txtDTB.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtHoTen.Text == "" || cbbKhoaVien.Text == "" || txtDTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Student student = context.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text);

                if (student == null)
                {
                    student = new Student();
                    student.StudentID = txtMSSV.Text;
                    student.FullName = txtHoTen.Text;
                    if (float.TryParse(txtDTB.Text, out float avgScore))
                    {
                        student.AverageScore = avgScore;
                    }
                    else
                    {
                        MessageBox.Show("Điểm trung bình phải là số thực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    student.FacultyID = (cbbKhoaVien.SelectedIndex + 1);

                    context.Students.Add(student);
                    context.SaveChanges();

                    students = context.Students.ToList();

                    GetStudentToDataGridView(students);

                    MessageBox.Show("Thêm sinh viên vào danh sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Sinh viên đã có trong danh sách!\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Student student = context.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text);

            if (student != null)
            {
                student.FullName = txtHoTen.Text;
                if (float.TryParse(txtDTB.Text, out float avgScore))
                {
                    student.AverageScore = avgScore;
                }
                else
                {
                    MessageBox.Show("Điểm trung bình phải là số thực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                student.FacultyID = (cbbKhoaVien.SelectedIndex + 1);

                context.SaveChanges();

                students = context.Students.ToList();

                GetStudentToDataGridView(students);

                MessageBox.Show("Cập nhật dữ liệu sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetValue();
            }
            else
            {
                MessageBox.Show("Không tìm thấy MSSV cần sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student student = context.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text);

            if (student != null)
            {
                if (MessageBox.Show("Bạn có chắc sẽ xóa sinh viên ra khỏi danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();

                    students = context.Students.ToList();

                    GetStudentToDataGridView(students);

                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbtnQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmFaculty frm = new frmFaculty();
            frm.ShowDialog();
        }

        private void mtsQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmFaculty frm = new frmFaculty();
            frm.ShowDialog();
        }

        private void tsbtnTimKiem_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }

        private void mtsTimKiem_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }

        private void mtsThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
